using System.ComponentModel.DataAnnotations.Schema;

namespace IdeaSystem.Entities
{
    public class Comment
    {
        public string cmt_Id { get; set; }
        public string cmt_Text { get; set; }
        public DateTime cmt_Datetime { get; set; }
        public string cmt_UserId { get; set; } // User
        [ForeignKey("cmt_UserId")]
        public  User users { get; set; }
        public string cmt_IdeaId { get; set; } // Idea
        [ForeignKey("cmt_IdeaId")]
        public Idea Idea { get; set; }
        public bool cmt_IsDelete { get; set; }
    }
}
