using System.ComponentModel;

namespace IdeaSystem.Entities
{
    public class Department
    {
        public string department_Id { set; get; }

        [DisplayName("Department Name")]
        public string department_Name { set; get; }

        [DisplayName("Is Delete")]
        public bool department_IsDelete { set; get; }


        public ICollection<User> userList { get; set; }
    }
}
