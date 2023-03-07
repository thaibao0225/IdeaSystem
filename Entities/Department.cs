namespace IdeaSystem.Entities
{
    public class Department
    {
        public string department_Id { set; get; }
        public string department_Name { set; get; }
        public bool department_IsDelete { set; get; }


        public ICollection<User> userList { get; set; }
    }
}
