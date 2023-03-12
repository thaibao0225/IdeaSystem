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


            //var testDt = ToDataTable(list);
            //var resuilt = ToExcelFile(testDt, "testExcel");


            //Downfile ----------------------------------------
            //var filepath = Path.Combine(Environment.CurrentDirectory, "ExcelFile", "testExcel.xlsx");
            //return File(System.IO.File.ReadAllBytes(filepath), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", System.IO.Path.GetFileName(filepath));





            return View();
        }

        public bool ToExcelFile( DataTable dt, string filename)
        {
            bool Success = false;
            //try
            //{
            XLWorkbook wb = new XLWorkbook();

            wb.Worksheets.Add(dt, "Sheet 1");

            if (filename.Contains("."))
            {
                int IndexOfLastFullStop = filename.LastIndexOf('.');

                filename = filename.Substring(0, IndexOfLastFullStop) + ".xlsx";

            }
            string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "ExcelFile"));
            filename = path + "\\" + filename + ".xlsx";

            wb.SaveAs(filename);

            Success = true;
            return Success;
        }

        public DataTable ToDataTable(List<string> list)
        {
            DataTable MethodResult = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("Item");
            dt.Columns.Add("Item2");

            foreach (string s in list)
            {
                DataRow dr = dt.NewRow();
                dr[0] = s;
                dr[1] = s;
                dt.Rows.Add(dr);

            }

            dt.AcceptChanges();

            MethodResult = dt;

            return MethodResult;

        }

    }
}
