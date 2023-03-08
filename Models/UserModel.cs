using System.ComponentModel.DataAnnotations;

namespace IdeaSystem.Models
{
    public class UserModel
    {
        [Key]
        public string user_Id { get; set; }
        public string user_Name { get; set; }
        public string user_RoleName { get; set; }
        public bool user_IsDelete { get; set; }
    }
}
