using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeaSystem.Controllers
{
    public class IdeaDetailController : Controller
    {
        // GET: IdeaDetailController
        [Route("/ideadetail")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: IdeaDetailController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IdeaDetailController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IdeaDetailController/Create
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

        // GET: IdeaDetailController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IdeaDetailController/Edit/5
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

        // GET: IdeaDetailController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IdeaDetailController/Delete/5
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
