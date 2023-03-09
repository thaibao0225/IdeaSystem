using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdeaSystem.Entities
{
    public class User : IdentityUser
    {
        public string user_DepartmentId { set; get; }
        [ForeignKey("user_DepartmentId")]
        public Department user_Department { set; get; }


        public List<Comment> commentList { set; get; }
        public List<View> viewList { set; get; }
        public List<React> reactList { set; get; }
        public List<Idea> ideaList { set; get; }
    }
}
