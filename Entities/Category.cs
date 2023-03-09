using System.ComponentModel;

namespace IdeaSystem.Entities
{
    public class Category
    {
        [DisplayName("Category Id")]
        public string category_Id { set; get; }

        [DisplayName("Category Name")]
        public string category_Name { set; get; }

        [DisplayName("Category IsDelete")]
        public bool category_IsDelete { set; get; }

        public List<Idea> ideaList { get; set; }
    }
}
