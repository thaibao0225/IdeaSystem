using IdeaSystem.Data;
using IdeaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IdeaSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext _context)
        {
            _logger = logger;
            context = _context;
        }

        public IActionResult Index()
        {
            var departmentNumberQuery = context.DepartmentTable.Where(x => x.department_IsDelete == false).Count();
            var categoryNumberQuery = context.CategoryTable.Where(x => x.category_IsDelete == false).Count();
            var ideaNumberQuery = context.IdeaTable.Where(x => x.idea_IsDelete == false).Count();
            var commentNumberQuery = context.CommentTable.Where(x => x.cmt_IsDelete == false).Count();

            ViewBag.DepartmentNumber = departmentNumberQuery;
            ViewBag.CategoryNumberQuery = categoryNumberQuery;
            ViewBag.IdeaNumberQuery = ideaNumberQuery;
            ViewBag.CommentNumberQuery = commentNumberQuery;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}