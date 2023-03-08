using IdeaSystem.Data;
using IdeaSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            return View();
        }

        // POST: IdeaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: IdeaController/Edit/5
        [Route("/idea/edit")]
        public ActionResult Edit(string id)
        {
            var query = context.IdeaTable.FirstOrDefault(x => x.idea_Id == id);
            return View(query);
        }

        // POST: IdeaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
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
