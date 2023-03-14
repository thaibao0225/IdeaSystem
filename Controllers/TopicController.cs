using AutoMapper;
using IdeaSystem.Data;
using IdeaSystem.Entities;
using IdeaSystem.Function;
using IdeaSystem.Models;
using IdeaSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using System.IO.Compression;
using System.Linq;
using System.Security.Claims;

namespace IdeaSystem.Controllers
{
    [Authorize(Roles = "Admin,Staff,Qa")]
    public class TopicController : Controller
    {
        private ApplicationDbContext context;
        private IExcel _excel;
        private readonly IMapper _mapper;

        private IManuallyTopicToTopicModel _manuallyTopicToTopicModel;
        public TopicController(ApplicationDbContext _context, IMapper mapper, IExcel excel)
        {
            context = _context;
            _mapper = mapper;
            _manuallyTopicToTopicModel = new ManuallyTopicToTopicModel(_context);
            _excel = excel;
        }

        // GET: TopicController
        [Route("/topic")]
        public ActionResult Index()
        {
            var query = context.TopicTable.Where(x => x.topic_IsDelete == false).ToList();

            List<TopicModel> topicListModel = new List<TopicModel>();
            foreach (var itemTopic in query)
            {
                TopicModel topicModel = new TopicModel();
                topicModel.topic_Id = itemTopic.topic_Id;
                topicModel.topic_ClosureDate = itemTopic.topic_ClosureDate;
                topicModel.topic_FinalClosureDate = itemTopic.topic_FinalClosureDate;
                topicModel.topic_Name = itemTopic.topic_Name;

                topicListModel.Add(topicModel);

            }


            return View(topicListModel);
        }

        // GET: TopicController/Details/5
        [Route("/topic/details")]
        public ActionResult Details(string id)
        {
            var query = context.TopicTable.FirstOrDefault(x => x.topic_Id == id);

            var ideaQuery = from a in context.TopicTable
                            join b in context.IdeaTable on a.topic_Id equals b.idea_TopicId
                            join c in context.ViewTable on b.idea_Id equals c.view_IdeadId
                            join d in context.ReactTable on b.idea_Id equals d.react_IdeadId
                            where (a.topic_Id == id)
                            select new { a, b, c, d };
            if (ideaQuery != null && ideaQuery.GetEnumerator().MoveNext())
            {
                var topicModelQueryFirst = _manuallyTopicToTopicModel.TransferToTopicModel(id);

                return View(topicModelQueryFirst);
            }
            else
            {
                var topicQuery = context.TopicTable.FirstOrDefault(x => x.topic_Id == id);
                if (topicQuery != null)
                {
                    TopicModel topicModel = new TopicModel();
                    topicModel.topic_Id = topicQuery.topic_Id;
                    topicModel.topic_Name = topicQuery.topic_Name;
                    topicModel.topic_ClosureDate = topicQuery.topic_ClosureDate;
                    topicModel.topic_FinalClosureDate = topicQuery.topic_FinalClosureDate;
                    return View(topicModel);
                }
            }


            return NotFound();
        }

        // GET: TopicController/Create
        [Route("/topic/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: TopicController/Create
        [HttpPost]
        [Route("/topic/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                string topicId = collection["topic_Id"];
                string topicName = collection["topic_Name"];
                string topicClosureDate = collection["topic_ClosureDate"];
                string topicFinalClosureDate = collection["topic_FinalClosureDate"];

                Topic topicCreate = new Topic()
                {
                    topic_Id = Guid.NewGuid().ToString(),
                    topic_Name = topicName,
                    topic_ClosureDate = DateTime.Parse(topicClosureDate),
                    topic_FinalClosureDate = DateTime.Parse(topicFinalClosureDate)
                };

                await context.TopicTable.AddAsync(topicCreate);

                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopicController/Edit/5
        [Route("/topic/edit")]
        public ActionResult Edit(string id)
        {
            var query = context.TopicTable.FirstOrDefault(x => x.topic_Id == id);
            return View(query);
        }

        // POST: TopicController/Edit/5
        [HttpPost]
        [Route("/topic/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, IFormCollection collection)
        {
            try
            {
                string topicId = collection["topic_Id"];
                string topicName = collection["topic_Name"];
                string topicClosureDate = collection["topic_ClosureDate"];
                string topicFinalClosureDate = collection["topic_FinalClosureDate"];

                var query = context.TopicTable.FirstOrDefault(x => x.topic_Id == topicId);

                if (query != null)
                {
                    query.topic_Name = topicName;
                    query.topic_ClosureDate = DateTime.Parse(topicClosureDate);
                    query.topic_FinalClosureDate = DateTime.Parse(topicFinalClosureDate);
                }

                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopicController/Delete/5
        [Route("/topic/delete")]
        public ActionResult Delete(string id)
        {
            var query = context.TopicTable.FirstOrDefault(x => x.topic_Id == id);
            return View(query);
        }

        // POST: TopicController/Delete/5
        [HttpPost]
        [Route("/topic/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {

                string topicId = collection["topic_Id"];

                var query = context.TopicTable.FirstOrDefault(x => x.topic_Id == topicId);

                if (query != null)
                {
                    query.topic_IsDelete = true;
                }

                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopicController/Like/5
        [Route("/topic/like")]
        public async Task<ActionResult> Like(string ideaId)
        {
            try
            {
                bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var reactQuery = context.ReactTable.FirstOrDefault(x => x.react_IdeadId == ideaId && x.react_UserId == userId);

                var ideaQuery = context.IdeaTable.FirstOrDefault(x => x.idea_Id == ideaId);

                if (reactQuery != null)
                {
                    reactQuery.react_React = 1;
                }
                else
                {
                    React reactCreate = new React();
                    reactCreate.react_Id = Guid.NewGuid().ToString();
                    reactCreate.react_React = 1;
                    reactCreate.react_UserId = userId;
                    reactCreate.react_IdeadId = ideaId;

                    await context.ReactTable.AddAsync(reactCreate);
                }

                await context.SaveChangesAsync();

                return RedirectToAction("Details", "topic", new { id = ideaQuery.idea_TopicId.ToString() });
            }
            catch
            {
                return View();
            }
        }


        // GET: TopicController/Like/5
        [Route("/topic/dislike")]
        public async Task<ActionResult> Dislike(string ideaId)
        {
            try
            {
                bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var reactQuery = context.ReactTable.FirstOrDefault(x => x.react_IdeadId == ideaId && x.react_UserId == userId);

                var ideaQuery = context.IdeaTable.FirstOrDefault(x => x.idea_Id == ideaId);

                if (reactQuery != null)
                {
                    reactQuery.react_React = -1;
                }
                else
                {
                    React reactCreate = new React();
                    reactCreate.react_Id = Guid.NewGuid().ToString();
                    reactCreate.react_React = -1;
                    reactCreate.react_UserId = userId;
                    reactCreate.react_IdeadId = ideaId;

                    await context.ReactTable.AddAsync(reactCreate);
                }

                await context.SaveChangesAsync();

                return RedirectToAction("Details", "topic", new { id = ideaQuery.idea_TopicId.ToString() });
            }
            catch
            {
                return View();
            }
        }


        // GET: TopicController/Like/5
        [Route("/topic/exportexcel")]
        public async Task<ActionResult> ExportExcel(string topicId)
        {
            try
            {
                bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


                List<IdeaDetailModel> ideaDetailModelList =  _manuallyTopicToTopicModel.TransferToIdeaDetailModelList(topicId);

                string excelName = topicId + "-Excel";
                var dataExcel = _excel.ExportExcelForIdeaModel(ideaDetailModelList);
                
                _excel.ToExcelFile(dataExcel, excelName, "Idea");
                


                //Downfile ----------------------------------------
                excelName = excelName + ".xlsx";
                var filepath = Path.Combine(Environment.CurrentDirectory, "ExcelFile", excelName);

                return File(System.IO.File.ReadAllBytes(filepath), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", System.IO.Path.GetFileName(filepath));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopicController/Like/5
        [Route("/topic/exportzip")]
        public ActionResult ExportZip(string topicId)
        {
            try
            {
                string topicIdPath = "topic-" + topicId;

                //// Zip file
                var currentdatefolder = DateTime.Now.ToString("yyyyMMddHHmmss");
                var zippath = Path.Combine(Environment.CurrentDirectory, "UploadedFiles", topicIdPath);
                var sourcezipPath = new PhysicalFileProvider(zippath).Root;
                var zipname = $"File_{currentdatefolder}.zip";
                var destinationPath = Path.Combine(Directory.GetCurrentDirectory(), "Zip", zipname);

                ZipFile.CreateFromDirectory(sourcezipPath, destinationPath);


                //// Down zip file
                ////Downfile ----------------------------------------


                return File(System.IO.File.ReadAllBytes(destinationPath), "application/zip", System.IO.Path.GetFileName(destinationPath));
            }
            catch
            {
                return View();
            }
        }

    }
}
