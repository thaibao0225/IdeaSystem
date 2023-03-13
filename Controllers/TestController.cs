using IdeaSystem.Data;
using IdeaSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Data;
using ClosedXML.Excel;

namespace IdeaSystem.Controllers
{
    public class TestController : Controller
    {
        private ApplicationDbContext context;
        private IManuallyTopicToTopicModel _manuallyTopicToTopicModel;
        readonly IBufferedFileUploadService _bufferedFileUploadService;
        private readonly IWebHostEnvironment environment;
        public TestController(ApplicationDbContext _context, IBufferedFileUploadService bufferedFileUploadService, IWebHostEnvironment hostEnvironment)
        {
            context = _context;
            _manuallyTopicToTopicModel = new ManuallyTopicToTopicModel(_context);
            _bufferedFileUploadService = bufferedFileUploadService;
            environment = hostEnvironment;
        }

        // GET: TestController
        [Route("/test")]
        public ActionResult Index()
        {
            //Downfile ----------------------------------------
            //var filepath = Path.Combine(Environment.CurrentDirectory, "UploadedFiles", "New Text Document.txt");
            //return File(System.IO.File.ReadAllBytes(filepath), "text/plain", System.IO.Path.GetFileName(filepath));


            //Create Excel file ----------------------------------------
            //List<string> list = new List<string>();
            //list.Add("1");
            //list.Add("2");
            //list.Add("3");
            //list.Add("4");


            


            //Downfile ----------------------------------------
            var filepath = Path.Combine(Environment.CurrentDirectory, "ExcelFile", "testExcel.xlsx");
            return File(System.IO.File.ReadAllBytes(filepath), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", System.IO.Path.GetFileName(filepath));





            //return View();
        }

        

    }
}
