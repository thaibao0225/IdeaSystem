using IdeaSystem.Data;
using IdeaSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeaSystem.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext context;
        public UserController(ApplicationDbContext _context)
        {
            context = _context;
        }

        // GET: UserController
        [Route("/user")]
        public ActionResult Index()
        {
            var query = from a in context.UserTable
                        join b in context.UserRoles on a.Id equals b.UserId
                        join c in context.Roles on b.RoleId equals c.Id
                        select new { a, b, c };

            var usersQuery = query.Select(x => new UserModel()
            {
                user_Id = x.a.Id,
                user_Name = x.a.UserName,
                user_RoleName = x.c.Name,
                user_IsDelete = x.a.EmailConfirmed
            });

            return View(usersQuery);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
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

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
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
