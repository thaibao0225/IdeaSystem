using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeaSystem.Controllers
{
    public class IdeaController : Controller
    {
        // GET: IdeaController
        [Route("/idea")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: IdeaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IdeaController/Create
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IdeaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IdeaController/Delete/5
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
