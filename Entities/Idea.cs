using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdeaSystem.Entities
{
    public class Idea
    {
        public string idea_Id { get; set; }

        [DisplayName("Text")]
        public string idea_Text { get; set; }
        [DisplayName("Content")]
        public string idea_Name { get; set; }

        [DisplayName("File Path")]
        public string idea_FilePath { get; set; }
        public string idea_FileName { get; set; }

        [DisplayName("Create On")]
        public DateTime idea_DateTime { get; set; }

        public string idea_UserId { get; set; } // User
        [ForeignKey("idea_UserId")]
        public User users { get; set; }


        public string idea_CategoryId { get; set; }  // Category
        [ForeignKey("idea_CategoryId")]
        public Category category { get; set; }



        public string idea_TopicId { get; set; }  // Topic
        [ForeignKey("idea_TopicId")]
        public Topic topic { get; set; }

        [DisplayName("Is Delete")]
        public bool idea_IsDelete { get; set; }  
        public bool idea_Agree { get; set; }  


        public List<Comment> commentList { get; set; }
        public List<React> reactList { get; set; }
        public List<View> viewList { get; set; }
    }
}
