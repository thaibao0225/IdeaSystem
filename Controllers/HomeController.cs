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
            var departmentNumberQuery = context.DepartmentTable.Count();
            var categoryNumberQuery = context.CategoryTable.Count();
            var ideaNumberQuery = context.IdeaTable.Count();
            var commentNumberQuery = context.CommentTable.Count();

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