using IdeaSystem.Data;
using IdeaSystem.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeaSystem.Controllers
{
    [Authorize(Roles = "Admin")]
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
            var query = context.DepartmentTable.Where(x => x.department_IsDelete == false).ToList();
            return View(query);
        }

        // GET: DepartmentController/Details/5
        [Route("/department/details")]
        public ActionResult Details(string id)
        {
            var query = context.DepartmentTable.FirstOrDefault(x => x.department_Id == id);
            if(query != null)
            {
                return View(query);
            }
            return NotFound();
            
        }

        // GET: DepartmentController/Create
        [Route("/department/create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: DepartmentController/Create
        [HttpPost]
        [Route("/department/create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                string departmentName = collection["department_Name"];

                Department departmentCreate = new Department()
                {
                    department_Id = Guid.NewGuid().ToString(),
                    department_Name = departmentName,
                    department_IsDelete = false
                };

                await context.DepartmentTable.AddAsync(departmentCreate);
                await context.SaveChangesAsync();

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
            var query = context.DepartmentTable.FirstOrDefault(x => x.department_Id == id);
            if (query != null)
            {
                return View(query);
            }
            return NotFound();
        }

        // POST: DepartmentController/Edit/5
        [HttpPost]
        [Route("/department/edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(string id, IFormCollection collection)
        {
            try
            {
                string departmentId = collection["department_Id"];
                string departmentName = collection["department_Name"];
                var query = context.DepartmentTable.FirstOrDefault(x => x.department_Id == departmentId);

                if (query != null)
                {
                    query.department_Name = departmentName;
                    await context.SaveChangesAsync();
                }


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
            var query = context.DepartmentTable.FirstOrDefault(x => x.department_Id == id);
            if (query != null)
            {
                return View(query);
            }
            return NotFound();
        }

        // POST: DepartmentController/Delete/5
        [HttpPost]
        [Route("/department/delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(string id, IFormCollection collection)
        {
            try
            {
                string departmentId = collection["department_Id"];
                string departmentName = collection["department_Name"];
                var query = context.DepartmentTable.FirstOrDefault(x => x.department_Id == departmentId);

                if (query != null)
                {
                    query.department_IsDelete = false;
                    await context.SaveChangesAsync();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
