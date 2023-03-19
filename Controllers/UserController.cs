using DocumentFormat.OpenXml.Spreadsheet;
using IdeaSystem.Data;
using IdeaSystem.Data.Common;
using IdeaSystem.Entities;
using IdeaSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace IdeaSystem.Controllers
{
    [Authorize(Roles = "Admin")]
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
                            //join b in context.UserRoles on a.Id equals b.UserId
                            //join c in context.Roles on b.RoleId equals c.Id
                        where (a.EmailConfirmed == true)
                        select new { a };

            var usersQuery = query.Select(x => new UserModel()
            {
                user_Id = x.a.Id,
                user_Name = x.a.UserName,
                //user_RoleName = x.c.Name,
                user_RoleName = "",
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

            if (usersQuery != null)
            {
                UserModel queryTest = usersQuery.First(x => x.user_Id == id);

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
            ViewBag.IsDisable = false;
            if (usersQuery != null)
            {
                UserModel queryTest = usersQuery.First(x => x.user_Id == id);
                ViewBag.IsDisable = IsCheckInternalUser(queryTest.user_Name);

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

            ViewBag.IsDisable = false;

            if (usersQuery != null)
            {
                UserModel queryTest = usersQuery.First(x => x.user_Id == id);
                ViewBag.IsDisable = IsCheckInternalUser(queryTest.user_Name);

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


        // GET: UserController/AsignRole/5
        [Route("/user/assignrole")]
        public ActionResult AssignRole(string id)
        {
            // Get Roles
            var roleQuery = context.RoleTable.Where(x => x.role_IsDelete == false).ToList();

            ViewBag.RoleNameSelect = roleQuery;


            // Get User
            var query = from a in context.UserTable
                        join b in context.UserRoles on a.Id equals b.UserId
                        join c in context.Roles on b.RoleId equals c.Id
                        where (a.Id == id)
                        select new { a, b, c };
            if (query != null && query.GetEnumerator().MoveNext())
            {
                var usersQuery = query.Select(x => new UserModel()
                {
                    user_Id = x.a.Id,
                    user_Name = x.a.UserName,
                    user_RoleName = x.c.Name,
                    user_IsDelete = x.a.EmailConfirmed
                });

                if (usersQuery != null)
                {
                    UserModel queryTest = usersQuery.First(x => x.user_Id == id);

                    return View(queryTest);
                }
            }
            else
            {
                var queryUser = from a in context.UserTable
                                where (a.Id == id)
                                select new { a };
                var usersQuery = queryUser.Select(x => new UserModel()
                {
                    user_Id = x.a.Id,
                    user_Name = x.a.UserName,
                    user_RoleName = "",
                    user_IsDelete = x.a.EmailConfirmed
                });

                if (usersQuery != null)
                {
                    UserModel queryTest = usersQuery.First(x => x.user_Id == id);

                    return View(queryTest);
                }
            }

            return NotFound();
        }

        // POST: UserController/AsignRole/5
        [HttpPost]
        [Route("/user/assignrole")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AssignRole(string id, IFormCollection collection)
        {
            try
            {
                string userId = collection["user_Id"];
                string userRoleIdExisiting = collection["user_RoleName"];
                string userRoleIdNew = collection["user_RoleIdNew"];

                var userRoleQuery = context.UserRoles.FirstOrDefault(x => x.UserId == userId);

                if (userRoleQuery != null)
                {
                    context.UserRoles.Remove(userRoleQuery);
                    await context.SaveChangesAsync();

                    userRoleQuery.RoleId = userRoleIdNew;
                    userRoleQuery.UserId = userId;

                    context.UserRoles.Add(userRoleQuery);
                    await context.SaveChangesAsync();

                }
                else
                {
                    var identityUserRole = new IdentityUserRole<string>
                    {
                        RoleId = userRoleIdNew,
                        UserId = userId
                    };

                    context.UserRoles.Add(identityUserRole);
                    await context.SaveChangesAsync();


                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public bool IsCheckInternalUser(string userName)
        {

            switch (userName)
            {
                case "admin@testgmail.com":
                    return true;
                case "qa@testgmail.com":
                    return true;
                case "staff@testgmail.com":
                    return true;
                default:
                    return false;
            }
        }
    }
}
