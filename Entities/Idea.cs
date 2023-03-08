using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdeaSystem.Entities
{
    public class Idea
    {
        public string idea_Id { get; set; }

        [DisplayName("Text")]
        public string idea_Text { get; set; }

        [DisplayName("File Path")]
        public string idea_FilePath { get; set; }

        [DisplayName("Create On")]
        public DateTime idea_DateTime { get; set; }
        public string idea_UserId { get; set; } // User
        [ForeignKey("idea_UserId")]
        public User users { get; set; }
        public string idea_CategoryId { get; set; }  // Category
        [ForeignKey("idea_CategoryId")]
        public Category category { get; set; }
        public string idea_Topic { get; set; }  // Topic
        [ForeignKey("idea_Topic")]
        public Topic topic { get; set; }

        [DisplayName("Is Delete")]
        public bool idea_IsDelete { get; set; }  


        public ICollection<Comment> commentList { get; set; }
        public ICollection<React> reactList { get; set; }
        public ICollection<View> viewList { get; set; }
    }
}
