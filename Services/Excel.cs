using ClosedXML.Excel;
using IdeaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Composition;
using System.Data;

namespace IdeaSystem.Services
{
    public class Excel : IExcel
    {
        public DataTable ExportExcelForIdeaModel(List<IdeaDetailModel> ideaList)
        {
            DataTable MethodResult = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Text");
            dt.Columns.Add("FileName");
            dt.Columns.Add("View");
            dt.Columns.Add("Like");
            dt.Columns.Add("Dislike");


            foreach (var s in ideaList)
            {
                DataRow dr = dt.NewRow();
                dr[0] = s.idea_Id;
                dr[1] = s.idea_Name;
                dr[2] = s.idea_Text;
                dr[3] = s.idea_FileName;
                dr[4] = s.idea_ViewNumber;
                dr[5] = s.idea_ReactLikeNumber;
                dr[6] = s.idea_ReactDislikeNumber;
                dt.Rows.Add(dr);

            }

            dt.AcceptChanges();

            MethodResult = dt;

            return MethodResult;

        }

        public bool ToExcelFile(DataTable dt, string filename, string sheetName)
        {
            bool Success = false;
            //try
            //{
            XLWorkbook wb = new XLWorkbook();

            wb.Worksheets.Add(dt, sheetName);

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

       

    }
}
