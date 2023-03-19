using IdeaSystem.Entities;
using IdeaSystem.Data.Common;
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
        public bool topic_IsDisableZip { get; set; } = false;
        public string topic_ColorRow
        {
            get
            {
                string colorRow = Attributes.SuccessNameColor;
                if ((topic_ClosureDate <= DateTime.Now)&& (topic_FinalClosureDate >= DateTime.Now))
                {
                    colorRow = Attributes.WarningNameColor;
                }
                if ((topic_ClosureDate <= DateTime.Now) && (topic_FinalClosureDate <= DateTime.Now))
                {
                    colorRow = Attributes.DangerNameColor;
                }
                return colorRow;
            }
            set { topic_ColorRow = value; }
        }
        public ICollection<IdeaDetailModel>? ideaList { get; set; }

    }
}
