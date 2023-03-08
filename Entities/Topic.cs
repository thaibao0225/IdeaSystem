using System.ComponentModel;

namespace IdeaSystem.Entities
{
    public class Topic
    {
        public string topic_Id { get; set; }

        [DisplayName("Topic Name")]
        public string topic_Name { get; set; }

        [DisplayName("Closure Date")]
        public DateTime topic_ClosureDate { get; set; }

        [DisplayName("Final Closure Date")]
        public DateTime topic_FinalClosureDate { get; set; }
        public bool topic_IsDelete { get; set; }

        public ICollection<Idea> ideaList { get; set; }

    }
}
