using IdeaSystem.Data;
using IdeaSystem.Data.Common;
using IdeaSystem.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace IdeaSystem.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private ApplicationDbContext context;
        public RoleController(ApplicationDbContext _context)
        {
            context = _context;
        }

        // GET: RoleController
        [Route("/role")]
        public ActionResult Index()
        {
            var query = context.RoleTable.Where(x => x.role_IsDelete == false).ToList();
            return View(query);
        }

        // GET: RoleController/Details/5
        [Route("/role/details")]
        public ActionResult Details(string id)
        {
            var query = context.RoleTable.FirstOrDefault(x => x.Id == id);
            return View(query);
        }

        // GET: RoleController/Create
        [Route("/role/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleController/Create
        [HttpPost]
        [Route("/role/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                string roleName = collection["Name"];
                string roleNormalizedName = roleName.ToLower();

                Role roleCreate = new Role()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = roleName,
                    NormalizedName = roleNormalizedName,
                    role_IsDelete = false
                };

                await context.RoleTable.AddAsync(roleCreate);
                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoleController/Edit/5
        [Route("/role/edit")]
        public ActionResult Edit(string id)
        {
            var query = context.RoleTable.FirstOrDefault(x => x.Id == id);

            ViewBag.IsDisable = false;

            if (query != null)
            {
                ViewBag.IsDisable = IsCheckInternalRole(query.Name);
            }

            return View(query);
        }

        // POST: RoleController/Edit/5
        [HttpPost]
        [Route("/role/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, IFormCollection collection)
        {
            try
            {
                string roleId = collection["Id"];
                string roleName = collection["Name"];

                string roleNormalizedName = roleName.ToLower();
                var query = context.RoleTable.FirstOrDefault(x => x.Id == roleId);
                if (query != null)
                {
                    query.Name = roleName;
                    query.NormalizedName = roleNormalizedName;
                }

                await context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoleController/Delete/5
        [Route("/role/delete")]
        public ActionResult Delete(string id)
        {
            var query = context.RoleTable.FirstOrDefault(x => x.Id == id);
            ViewBag.IsDisable = false;

            if(query != null)
            {
                ViewBag.IsDisable = IsCheckInternalRole(query.Name);
            }
            

            return View(query);
        }

        // POST: RoleController/Delete/5
        [HttpPost]
        [Route("/role/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            try
            {
                string roleId = collection["Id"];
                var query = context.RoleTable.FirstOrDefault(x => x.Id == roleId);
                if (query != null)
                {
                    query.role_IsDelete = true;
                }

                await context.SaveChangesAsync();


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public bool IsCheckInternalRole(string roleName)
        {

            switch (roleName)
            {
                case "Admin":
                    return true;
                case "Qa":
                    return true;
                case "Staff":
                    return true;
                default:
                    return false;
            }
        }
    }
}
