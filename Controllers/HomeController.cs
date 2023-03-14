using IdeaSystem.Data;
using IdeaSystem.Data.Common;
using IdeaSystem.Entities;
using IdeaSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Claims;

namespace IdeaSystem.Controllers
{
    [Authorize(Roles = "Admin,Staff,Qa")]
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
            PageloadRoleName();
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
        public void PageloadRoleName()
        {
            bool checkLogin = (User?.Identity.IsAuthenticated).GetValueOrDefault();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var RoleId = context.UserRoles.FirstOrDefault(x => x.UserId == userId);
            var RoleName = context.RoleTable.FirstOrDefault(x => x.Id == RoleId.RoleId);

            if (RoleName != null)
            {
                switch (RoleName.Name)
                {
                    case "Staff":
                        // code block
                        CommonTable.isDasdboardShow = true;
                        CommonTable.isUserShow = false;
                        CommonTable.isRoleShow = false;
                        CommonTable.isCategoryShow = false;
                        CommonTable.isDepartmentShow = false;
                        CommonTable.isTopicShow = true;
                        CommonTable.isIdeaShow = true;

                        break;
                    case "Admin":
                        // code block
                        CommonTable.isDasdboardShow = true;
                        CommonTable.isUserShow = true;
                        CommonTable.isRoleShow = true;
                        CommonTable.isCategoryShow = true;
                        CommonTable.isDepartmentShow = true;
                        CommonTable.isTopicShow = true;
                        CommonTable.isIdeaShow = true;
                        break;
                    case "Qa":
                        // code block
                        CommonTable.isDasdboardShow = true;
                        CommonTable.isUserShow = false;
                        CommonTable.isRoleShow = false;
                        CommonTable.isCategoryShow = true;
                        CommonTable.isDepartmentShow = true;
                        CommonTable.isTopicShow = true;
                        CommonTable.isIdeaShow = true;
                        break;
                    default:
                        // code block
                        CommonTable.isDasdboardShow = true;
                        CommonTable.isUserShow = true;
                        CommonTable.isRoleShow = true;
                        CommonTable.isCategoryShow = true;
                        CommonTable.isDepartmentShow = true;
                        CommonTable.isTopicShow = true;
                        CommonTable.isIdeaShow = true;
                        break;
                }
            }
            
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