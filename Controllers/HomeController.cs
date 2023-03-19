using DocumentFormat.OpenXml.Vml.Office;
using DocumentFormat.OpenXml.Vml;
using IdeaSystem.Data;
using IdeaSystem.Data.Common;
using IdeaSystem.Entities;
using IdeaSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Numerics;
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


            var stasticDepartment = from a in context.DepartmentTable
                                    join b in context.UserTable on a.department_Id equals b.user_DepartmentId
                                    join c in context.IdeaTable on b.Id equals c.idea_UserId
                                    where a.department_IsDelete == false
                                    group a by a.department_Name into aDepartment
                                    select new
                                    {
                                        DepartmentName = aDepartment.Key,
                                        Count = aDepartment.Count(),
                                    };
            List<DepartmentModel> departmentList = new List<DepartmentModel>();
            int sumDepartment = 0;
            foreach (var item in stasticDepartment)
            {
                DepartmentModel departmentModel = new DepartmentModel();
                departmentModel.department_Name = item.DepartmentName;
                departmentModel.department_NumberOfIdea = item.Count;
                departmentModel.department_PercenOfIdea = 0;
                sumDepartment = sumDepartment + departmentModel.department_NumberOfIdea;

                departmentList.Add(departmentModel);
            }
            List<DepartmentModel> departmentPercenList = new List<DepartmentModel>();
            foreach (var item in departmentList)
            {
                DepartmentModel departmentModel = new DepartmentModel();
                departmentModel.department_Name = item.department_Name;
                departmentModel.department_NumberOfIdea = item.department_NumberOfIdea;
                departmentModel.department_PercenOfIdea = (int)(0.5f + ((100f * departmentModel.department_NumberOfIdea) / sumDepartment)); 


                departmentPercenList.Add(departmentModel);
            }

            var stasticDepartmentContributor = from a in context.DepartmentTable
                                    join b in context.UserTable on a.department_Id equals b.user_DepartmentId
                                    where a.department_IsDelete == false
                                    group a by a.department_Name into aDepartment
                                    select new
                                    {
                                        DepartmentName = aDepartment.Key,
                                        Count = aDepartment.Count(),
                                    };

            List<DepartmentModel> departmentContributorList = new List<DepartmentModel>();
            foreach (var item in stasticDepartment)
            {
                DepartmentModel departmentModel = new DepartmentModel();
                departmentModel.department_Name = item.DepartmentName;
                departmentModel.department_NumberOfContributorWithinDepartment = item.Count;

                departmentContributorList.Add(departmentModel);
            }
            ViewBag.departmentContributorList = departmentContributorList;

            //var playersPerTeam =
            //from player in players
            //group player by player.Team into playerGroup
            //select new
            //{
            //    Team = playerGroup.Key,
            //    Count = playerGroup.Count(),
            //};

            return View(departmentPercenList);
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