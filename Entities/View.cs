using System.ComponentModel.DataAnnotations.Schema;

namespace IdeaSystem.Entities
{
    public class View
    {
        public string view_Id { get; set; }
        public int view_VisitTime { get; set; }
        public string view_UserId { get; set; } // User
        [ForeignKey("view_UserId")]
        public User users { get; set; }
        public string view_IdeadId { get; set; } // Idea
        [ForeignKey("view_IdeadId")]
        public Idea Idea { get; set; }
    }
}
