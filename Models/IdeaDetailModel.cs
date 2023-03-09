using MessagePack;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace IdeaSystem.Models
{
    public class IdeaDetailModel
    {
        public string idea_Id { get; set; }

        [DisplayName("Text")]
        public string idea_Text { get; set; }

        [DisplayName("Create On")]
        public DateTime idea_CreateOn { get; set; }

        [DisplayName("File")]
        public string idea_FilePath { get; set; }
        public string idea_UserId { get; set; }

        [DisplayName("User Name")]
        public string idea_UserName { get; set; }
        public string idea_TopicId { get; set; }

        [DisplayName("Topic Name")]
        public string idea_TopicName { get; set; }

        [DisplayName("Category Name")]
        public string idea_CategoryId { get; set; }

        [DisplayName("Category Name")]
        public string idea_CategoryName { get; set; }

        [DisplayName("Deadline 1")]
        public DateTime idea_Deadline1 { get; set; }

        [DisplayName("Deadline 2")]
        public DateTime idea_Deadline2 { get; set; }



        [DisplayName("View")]
        public List<ViewModel> viewList { get; set; }

        [DisplayName("React")]
        public List<ReactModel> reactList { get; set; }
        [DisplayName("Comment")]
        public List<CommentModel> commentList { get; set; }

    }
}
