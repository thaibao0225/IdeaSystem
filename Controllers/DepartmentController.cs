using IdeaSystem.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeaSystem.Controllers
{
    public class DepartmentController : Controller
    {
        private ApplicationDbContext context;
        public DepartmentController(ApplicationDbContext _context)
        {
            context = _context;
        }

        // GET: DepartmentController
        [Route("/department")]
        public ActionResult Index()
        {
            var query = context.DepartmentTable.ToList();
            return View(query);
        }

        // GET: DepartmentController/Details/5
        [Route("/department/details")]
        public ActionResult Details(string id)
        {
            var query = context.RoleTable.FirstOrDefault(x => x.Id == id);
            return View(query);
        }

        // GET: DepartmentController/Create
        [Route("/department/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
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

        // GET: DepartmentController/Edit/5
        [Route("/department/edit")]
        public ActionResult Edit(string id)
        {
            var query = context.RoleTable.FirstOrDefault(x => x.Id == id);
            return View(query);
        }

        // POST: DepartmentController/Edit/5
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

        // GET: DepartmentController/Delete/5
        [Route("/department/delete")]
        public ActionResult Delete(string id)
        {
            var query = context.RoleTable.FirstOrDefault(x => x.Id == id);
            return View(query);
        }

        // POST: DepartmentController/Delete/5
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
