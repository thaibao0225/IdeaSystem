using IdeaSystem.Data;
using IdeaSystem.Data.Common;
using IdeaSystem.Entities;
using IdeaSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace IdeaSystem.Controllers
{
    public class IdeaController : Controller
    {
        private ApplicationDbContext context;
        public IdeaController(ApplicationDbContext _context)
        {
            context = _context;
        }

        // GET: IdeaController
        [Route("/idea")]
        public ActionResult Index()
        {
            var query = from a in context.IdeaTable
                        join b in context.TopicTable on a.idea_Topic equals b.topic_Id
                        select new { a, b };
            var ideaquery = query.Select(x => new IdeaModel()
            {
                idea_Id = x.a.idea_Id,
                idea_Text = x.a.idea_Text,
                idea_CreateOn = x.a.idea_DateTime,
                idea_Deadline1 = x.b.topic_ClosureDate,
                idea_Deadline2 = x.b.topic_FinalClosureDate
            });


            return View(ideaquery);
        }

        // GET: IdeaController/Details/5
        [Route("/idea/details")]
        public ActionResult Details(string id)
        {
            var query = context.IdeaTable.FirstOrDefault(x => x.idea_Id == id);
            return View(query);
        }

        // GET: IdeaController/Create
        [Route("/idea/create")]
        public ActionResult Create()
        {
            var categoriesQuery = context.CategoryTable.Where(x => x.category_IsDelete == false).ToList();
            ViewBag.CategoriesNameSelect = categoriesQuery;
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
                string ideaId = collection["idea_Id"];
                string ideaText = collection["idea_Text"];
                string ideaDeadline1 = collection["idea_Deadline1"];
                string ideaDeadline2 = collection["idea_Deadline2"];
                string categoryId = collection["idea_CategoryId"];

                var topicId = Guid.NewGuid().ToString();
                Topic topicCreate = new Topic()
                {
                    topic_Id = topicId,
                    topic_Name = topicId,
                    topic_ClosureDate = DateTime.Parse(ideaDeadline1),
                    topic_FinalClosureDate = DateTime.Parse(ideaDeadline2)
                };

                await context.TopicTable.AddAsync(topicCreate);

                Idea ideaCreate = new Idea()
                {
                    idea_Id = Guid.NewGuid().ToString(),
                    idea_Text = ideaText,
                    idea_FilePath = "",
                    idea_DateTime = DateTime.Now,
                    idea_UserId = DataTest.adminId, ///
                    idea_CategoryId = categoryId,
                    idea_Topic = topicId

                };

                await context.IdeaTable.AddAsync(ideaCreate);

                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
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
                            join b in context.IdeaTable on a.topic_Id equals b.idea_Topic
                            join c in context.CategoryTable on b.idea_CategoryId equals c.category_Id
                            where (b.idea_Id == id)
                            select new { a, b, c };

            var ideaModel = ideaQuery.Select(x => new IdeaDetailModel()
            { 
                idea_Id = x.b.idea_Id,
                idea_Text = x.b.idea_Text,
                idea_FilePath = x.b.idea_FilePath,
                idea_CreateOn = x.b.idea_DateTime,
                idea_Deadline1 = x.a.topic_ClosureDate,
                idea_Deadline2 = x.a.topic_FinalClosureDate,
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
                if(ideaQuery != null)
                {
                    ideaQuery.idea_Text = ideaText;
                    ideaQuery.idea_CategoryId = categoryId;
                }

                // Topic
                var topicQuery = context.TopicTable.FirstOrDefault(x => x.topic_Id == ideaTopicId);
                if(topicQuery != null)
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
            var query = context.IdeaTable.FirstOrDefault(x => x.idea_Id == id);
            return View(query);
        }

        // POST: IdeaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
