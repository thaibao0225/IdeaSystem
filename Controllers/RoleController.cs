using IdeaSystem.Data;
using IdeaSystem.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeaSystem.Controllers
{
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
            var query = context.RoleTable.ToList();
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
                    role_IsDelete = true
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
            return View(query);
        }

        // POST: RoleController/Delete/5
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
