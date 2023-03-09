using IdeaSystem.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IdeaSystem.Models
{
    public class TopicModel
    {
        public string topic_Id { get; set; }

        [DisplayName("Topic Name")]
        public string topic_Name { get; set; }
        public DateTime idea_CreateOn { get; set; }

        [DisplayName("Topic ClosureDate")]
        public DateTime topic_ClosureDate { get; set; }

        [DisplayName("Topic FinalClosureDate")]
        public DateTime topic_FinalClosureDate { get; set; }
        public bool topic_IsDelete { get; set; }
        public ICollection<IdeaDetailModel>? ideaList { get; set; }

    }
}
