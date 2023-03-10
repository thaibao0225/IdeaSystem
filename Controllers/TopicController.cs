using AutoMapper;
using IdeaSystem.Data;
using IdeaSystem.Entities;
using IdeaSystem.Function;
using IdeaSystem.Models;
using IdeaSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace IdeaSystem.Controllers
{
    public class TopicController : Controller
    {
        private ApplicationDbContext context;
        private readonly IMapper _mapper;

        private IManuallyTopicToTopicModel _manuallyTopicToTopicModel;
        public TopicController(ApplicationDbContext _context, IMapper mapper)
        {
            context = _context;
            _mapper = mapper;
            _manuallyTopicToTopicModel = new ManuallyTopicToTopicModel(_context);
        }

        // GET: TopicController
        [Route("/topic")]
        public ActionResult Index()
        {
            var query = context.TopicTable.Where(x => x.topic_IsDelete == false).ToList();


            return View(query);
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


            if (ideaQuery != null)
            {
                var topicModelQueryFirst = _manuallyTopicToTopicModel.TransferToTopicModel(id);

                return View(topicModelQueryFirst);
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

    }
}
