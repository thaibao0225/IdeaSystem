namespace IdeaSystem.Entities
{
    public class Category
    {
        public string category_Id { set; get; }
        public string category_Name { set; get; }
        public bool category_IsDelete { set; get; }

        public ICollection<Idea> ideaList { get; set; }
    }
}
