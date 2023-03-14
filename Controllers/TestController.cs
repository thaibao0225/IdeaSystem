using IdeaSystem.Data;
using IdeaSystem.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Data;
using ClosedXML.Excel;
using Microsoft.Extensions.FileProviders;
using System.IO.Compression;

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
            var currentdatefolder = DateTime.Now.ToString("yyyyMMddHHmmss");
            //var zippath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ZipsUpload", currentdatefolder);
            var zippath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ZipsUpload", currentdatefolder);
            var sourcezipPath = new PhysicalFileProvider(zippath).Root;
            var zipname = $"File_{currentdatefolder}.zip";
            var destinationPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "CreatedZip", zipname);
            ZipFile.CreateFromDirectory(sourcezipPath, destinationPath);

            return Json(new { status = true, Message = "Files Uploaded Successfully!" });
        }

        

    }
}
