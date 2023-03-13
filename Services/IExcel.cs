using IdeaSystem.Models;
using System.Data;

namespace IdeaSystem.Services
{
    public interface IExcel
    {
        public DataTable ExportExcelForIdeaModel(List<IdeaDetailModel> ideaList);
        public bool ToExcelFile(DataTable dt, string filename, string sheetName);
    }
}
