using IdeaSystem.Data;
using IdeaSystem.Data.Common;
using IdeaSystem.Entities;
using IdeaSystem.Models;
using IdeaSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace IdeaSystem.Controllers
{
    public class IdeaController : Controller
    {
        private ApplicationDbContext context;
        private IManuallyTopicToTopicModel _manuallyTopicToTopicModel;
        public IdeaController(ApplicationDbContext _context)
        {
            context = _context;
            _manuallyTopicToTopicModel = new ManuallyTopicToTopicModel(_context);
        }

        // GET: IdeaController
        [Route("/idea")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: IdeaController/Details/5
        [Route("/idea/details")]
        public async Task<ActionResult> Details(string id)
        {
            bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // view First Query 

            var viewFirstQuery = context.ViewTable.FirstOrDefault(x => x.view_IdeadId == id);
            if (viewFirstQuery != null)
            {
                viewFirstQuery.view_VisitTime++;
            }
            else
            {
                View viewCreate = new View();
                viewCreate.view_Id = "";
                viewCreate.view_VisitTime = 1;
                viewCreate.view_UserId = userId;
                viewCreate.view_IdeadId = id;

                await context.ViewTable.AddAsync(viewCreate);
            }

            // Comment Query
            var commentQuery = context.CommentTable.Where(x => x.cmt_IdeaId == id);


            // Idea Query
            //var ideaQuery = from a in context.TopicTable
            //                join b in context.IdeaTable on a.topic_Id equals b.idea_TopicId
            //                join c in context.CategoryTable on b.idea_CategoryId equals c.category_Id
            //                where (b.idea_Id == id)
            //                select new { a, b, c };

            //var ideaModel = ideaQuery.Select(x => new IdeaDetailModel()
            //{
            //    idea_Id = x.b.idea_Id,
            //    idea_Text = x.b.idea_Text,
            //    idea_FilePath = x.b.idea_FilePath,
            //    idea_CreateOn = x.b.idea_DateTime,
            //    idea_CategoryId = x.b.idea_CategoryId,
            //    idea_UserId = x.b.idea_UserId,
            //    idea_CategoryName = x.c.category_Name,
            //    idea_TopicId = x.a.topic_Id,
            //    idea_Name = x.b.idea_Name,

            //});

            var ideaModel = _manuallyTopicToTopicModel.TransferToIdeaDetailModel(id);
            if (ideaModel != null )
            {
                //IdeaDetailModel ideaFirst = ideaModel.First(x => x.idea_Id == id);
                await context.SaveChangesAsync();
                return View(ideaModel);
            }

            await context.SaveChangesAsync();
            return NoContent();

            
        }

        // GET: IdeaController/Create
        [Route("/idea/create")]
        public ActionResult Create(string topicId)
        {
            var category = context.CategoryTable.Where(x => x.category_IsDelete == false).ToList();
            ViewBag.categoryList = category;
            ViewBag.topicId = topicId;
            return View();
        }

        // POST: IdeaController/Create
        [HttpPost]
        [Route("/idea/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                string ideaId = Guid.NewGuid().ToString(); //
                string ideaText = collection["idea_Text"];
                string ideaName = collection["idea_Name"];
                string ideaAgreeString = collection["idea_Agree"];
                DateTime ideaCreateOn = DateTime.Now;
                string ideaFilePath = collection["idea_FilePath"];
                string ideaUserId = userId; // 
                string ideaTopicId = collection["idea_TopicId"]; //
                string ideaCategoryId = collection["idea_CategoryId"];

                bool ideaAgree = false;
                if (ideaAgreeString == "true,false")
                {
                    ideaAgree = true;
                }

                Idea ideaCreate = new Idea();
                ideaCreate.idea_Id = ideaId;
                ideaCreate.idea_Name = ideaName;
                ideaCreate.idea_Text = ideaText;
                ideaCreate.idea_Agree = ideaAgree;
                ideaCreate.idea_DateTime = ideaCreateOn;
                ideaCreate.idea_FilePath = ideaFilePath;
                ideaCreate.idea_UserId = ideaUserId;
                ideaCreate.idea_TopicId = ideaTopicId;
                ideaCreate.idea_CategoryId = ideaCategoryId;

                await context.IdeaTable.AddAsync(ideaCreate);



                // Create View Table for this Idea
                View viewCreate = new View();
                viewCreate.view_Id = Guid.NewGuid().ToString();
                viewCreate.view_VisitTime = 0;
                viewCreate.view_UserId = ideaUserId;
                viewCreate.view_IdeadId = ideaId;
                await context.ViewTable.AddAsync(viewCreate);

                // Create React Table for this Idea
                React reactCreate = new React();
                reactCreate.react_Id = Guid.NewGuid().ToString();
                reactCreate.react_React = 0;
                reactCreate.react_UserId = ideaUserId;
                reactCreate.react_IdeadId = ideaId;
                await context.ReactTable.AddAsync(reactCreate);


                await context.SaveChangesAsync();


                return RedirectToAction("Details", "topic", new { id = ideaTopicId.ToString() });
            }
            catch
            {
                return View();
            }
        }

        // GET: IdeaController/Edit/5
        [Route("/idea/edit")]
        public ActionResult Edit(string id)
        {
            // Category Query
            var categoriesQuery = context.CategoryTable.Where(x => x.category_IsDelete == false).ToList();
            ViewBag.CategoriesNameSelect = categoriesQuery;

            // Idea Query
            var ideaQuery = from a in context.TopicTable
                            join b in context.IdeaTable on a.topic_Id equals b.idea_TopicId
                            join c in context.CategoryTable on b.idea_CategoryId equals c.category_Id
                            where (b.idea_Id == id)
                            select new { a, b, c };

            var ideaModel = ideaQuery.Select(x => new IdeaDetailModel()
            {
                idea_Id = x.b.idea_Id,
                idea_Text = x.b.idea_Text,
                idea_FilePath = x.b.idea_FilePath,
                idea_CreateOn = x.b.idea_DateTime,
                idea_TopicId = x.a.topic_Id,
                idea_CategoryId = x.b.idea_CategoryId,
                idea_UserId = x.b.idea_UserId,
                idea_CategoryName = x.c.category_Name
            });

            IdeaDetailModel ideaFirst = ideaModel.First(x => x.idea_Id == id);
            ViewBag.CategoriesNameExisting = ideaFirst.idea_CategoryName;

            return View(ideaFirst);
        }

        // POST: IdeaController/Edit/5
        [HttpPost]
        [Route("/idea/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, IFormCollection collection)
        {
            try
            {
                string ideaId = collection["idea_Id"];
                string ideaText = collection["idea_Text"];
                string categoryId = collection["idea_CategoryId"];

                string ideaTopicId = collection["idea_TopicId"];
                string ideaDeadline1 = collection["idea_Deadline1"];
                string ideaDeadline2 = collection["idea_Deadline2"];


                // Idea
                var ideaQuery = context.IdeaTable.FirstOrDefault(x => x.idea_Id == ideaId);
                if (ideaQuery != null)
                {
                    ideaQuery.idea_Text = ideaText;
                    ideaQuery.idea_CategoryId = categoryId;
                }

                // Topic
                var topicQuery = context.TopicTable.FirstOrDefault(x => x.topic_Id == ideaTopicId);
                if (topicQuery != null)
                {
                    topicQuery.topic_ClosureDate = DateTime.Parse(ideaDeadline1);
                    topicQuery.topic_FinalClosureDate = DateTime.Parse(ideaDeadline2);
                }

                await context.SaveChangesAsync();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: IdeaController/Delete/5
        [Route("/idea/delete")]
        public ActionResult Delete(string id)
        {
            // Category Query
            var categoriesQuery = context.CategoryTable.Where(x => x.category_IsDelete == false).ToList();
            ViewBag.CategoriesNameSelect = categoriesQuery;

            // Idea Query
            var ideaQuery = from a in context.TopicTable
                            join b in context.IdeaTable on a.topic_Id equals b.idea_TopicId
                            join c in context.CategoryTable on b.idea_CategoryId equals c.category_Id
                            where (b.idea_Id == id)
                            select new { a, b, c };

            var ideaModel = ideaQuery.Select(x => new IdeaDetailModel()
            {
                idea_Id = x.b.idea_Id,
                idea_Text = x.b.idea_Text,
                idea_FilePath = x.b.idea_FilePath,
                idea_CreateOn = x.b.idea_DateTime,
                idea_TopicId = x.a.topic_Id,
                idea_CategoryId = x.b.idea_CategoryId,
                idea_UserId = x.b.idea_UserId,
                idea_CategoryName = x.c.category_Name
            });

            IdeaDetailModel ideaFirst = ideaModel.First(x => x.idea_Id == id);
            ViewBag.CategoriesNameExisting = ideaFirst.idea_CategoryName;

            return View(ideaFirst);
        }

        // POST: IdeaController/Delete/5
        [HttpPost]
        [Route("/idea/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {
                string ideaId = collection["idea_Id"];

                // Idea
                var ideaQuery = context.IdeaTable.FirstOrDefault(x => x.idea_Id == ideaId);
                if (ideaQuery != null)
                {
                    ideaQuery.idea_IsDelete = true;
                }

                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       



        
    }
}
