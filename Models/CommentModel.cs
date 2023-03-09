using IdeaSystem.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace IdeaSystem.Models
{
    public class CommentModel
    {
        public string cmt_Id { get; set; }

        [DisplayName("Text")]
        public string cmt_Text { get; set; }

        [DisplayName("Create On")]
        public DateTime cmt_Datetime { get; set; }
        public string cmt_UserId { get; set; } // User
        public string cmt_IdeaId { get; set; } // Idea
        public bool cmt_IsDelete { get; set; }
    }
}
