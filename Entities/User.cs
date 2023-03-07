using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdeaSystem.Entities
{
    public class User : IdentityUser
    {
        public string user_DepartmentId { set; get; }
        [ForeignKey("user_DepartmentId")]
        public Department user_Department { set; get; }


        public ICollection<Comment> commentList { set; get; }
        public ICollection<View> viewList { set; get; }
        public ICollection<React> reactList { set; get; }
        public ICollection<Idea> ideaList { set; get; }
    }
}
