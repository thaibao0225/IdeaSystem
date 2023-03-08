using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdeaSystem.Entities
{
    public class React
    {
        public string react_Id { get; set; }

        [DisplayName("React")]
        public int react_React { get; set; } // -1, 0 , 1
        public string react_UserId { get; set; } // User
        [ForeignKey("react_UserId")]
        public User users { get; set; }
        public string react_IdeadId { get; set; } // Idea
        [ForeignKey("react_IdeadId")]
        public Idea Idea { get; set; }
    }
}
