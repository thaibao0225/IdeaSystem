using IdeaSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeaSystem.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext context;
        public CategoryController(ApplicationDbContext _context)
        {
            context = _context;
        }

        // GET: CategoryController
        [Route("/category")]
        public ActionResult Index()
        {
            var query = context.CategoryTable.ToList();
            return View(query);
        }

        // GET: CategoryController/Details/5
        [Route("/category/details")]
        public ActionResult Details(string id)
        {
            var query = context.CategoryTable.FirstOrDefault(x => x.category_Id == id);
            return View(query);
        }

        // GET: CategoryController/Create
        [Route("/category/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
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

        // GET: CategoryController/Edit/5
        [Route("/category/edit")]
        public ActionResult Edit(string id)
        {
            var query = context.CategoryTable.FirstOrDefault(x => x.category_Id == id);
            return View(query);
        }

        // POST: CategoryController/Edit/5
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

        // GET: CategoryController/Delete/5
        [Route("/category/delete")]
        public ActionResult Delete(string id)
        {
            var query = context.CategoryTable.FirstOrDefault(x => x.category_Id == id);
            return View(query);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
