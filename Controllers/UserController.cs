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
                        where (a.EmailConfirmed == true)
                        select new { a, c };

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
        [Route("/user/details")]
        public ActionResult Details(string id)
        {
            var query = from a in context.UserTable
                        join b in context.UserRoles on a.Id equals b.UserId
                        join c in context.Roles on b.RoleId equals c.Id
                        where (a.Id == id)
                        select new { a, b, c };

            var usersQuery = query.Select(x => new UserModel()
            {
                user_Id = x.a.Id,
                user_Name = x.a.UserName,
                user_RoleName = x.c.Name,
                user_IsDelete = x.a.EmailConfirmed
            });

            if(usersQuery != null)
            {
                UserModel queryTest = usersQuery.FirstOrDefault(x => x.user_Id == id);

                return View(queryTest);
            }
            return NotFound();
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
        [Route("/user/edit")]
        public ActionResult Edit(string id)
        {
            var query = from a in context.UserTable
                        join b in context.UserRoles on a.Id equals b.UserId
                        join c in context.Roles on b.RoleId equals c.Id
                        where (a.Id == id)
                        select new { a, b, c };

            var usersQuery = query.Select(x => new UserModel()
            {
                user_Id = x.a.Id,
                user_Name = x.a.UserName,
                user_RoleName = x.c.Name,
                user_IsDelete = x.a.EmailConfirmed
            });

            if (usersQuery != null)
            {
                UserModel queryTest = usersQuery.FirstOrDefault(x => x.user_Id == id);

                return View(queryTest);
            }
            return NotFound();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [Route("/user/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, IFormCollection collection)
        {
            try
            {
                string userId = collection["user_Id"];
                string userName = collection["user_Name"];

                var userQuery = context.UserTable.FirstOrDefault(x => x.Id == userId);
                if (userQuery != null)
                {
                    userQuery.UserName = userName;
                }

                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        [Route("/user/delete")]
        public ActionResult Delete(string id)
        {
            var query = from a in context.UserTable
                        join b in context.UserRoles on a.Id equals b.UserId
                        join c in context.Roles on b.RoleId equals c.Id
                        where (a.Id == id)
                        select new { a, b, c };

            var usersQuery = query.Select(x => new UserModel()
            {
                user_Id = x.a.Id,
                user_Name = x.a.UserName,
                user_RoleName = x.c.Name,
                user_IsDelete = x.a.EmailConfirmed
            });

            if (usersQuery != null)
            {
                UserModel queryTest = usersQuery.FirstOrDefault(x => x.user_Id == id);

                return View(queryTest);
            }
            return NotFound();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [Route("/user/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {
                string userId = collection["user_Id"];
                string userName = collection["user_Name"];

                var userQuery = context.UserTable.FirstOrDefault(x => x.Id == userId);
                if (userQuery != null)
                {
                    userQuery.EmailConfirmed = false;
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
