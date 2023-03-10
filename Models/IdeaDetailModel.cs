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
        [DisplayName("Name")]
        public string idea_Name { get; set; }

        [DisplayName("Create On")]
        public DateTime idea_CreateOn { get; set; }

        [DisplayName("File")]
        public string idea_FilePath { get; set; }
        public string idea_UserId { get; set; }

        [DisplayName("User Name")]
        public string idea_UserName { get; set; }
        public string idea_TopicId { get; set; }


        [DisplayName("Category Name")]
        public string idea_CategoryId { get; set; }

        [DisplayName("Category Name")]
        
        public string idea_CategoryName { get; set; }
        [DisplayName("Agree with creating idea")]
        public bool idea_Agree { get; set; }



        [DisplayName("View")]
        public List<ViewModel> viewList { get; set; }

        [DisplayName("React")]
        public List<ReactModel> reactList { get; set; }
        [DisplayName("Comment")]
        public List<CommentModel> commentList { get; set; }



        public int idea_ViewNumber
        {
            get {
                int viewCount = 0;
                foreach (var viewItem in viewList)
                {
                    viewCount = viewItem.view_VisitTime + viewCount;
                }
                return viewCount; 
            }
            set { idea_ViewNumber = value; }
        }
        public int idea_ReactLikeNumber
        {
            get
            {
                int reactLikeCount = 0;
                foreach (var reactItem in reactList)
                {
                    if (reactItem.react_React == 1)
                    {
                        reactLikeCount++;
                    }
                }
                return reactLikeCount;
            }
            set { idea_ReactLikeNumber = value; }
        }

        public int idea_ReactDislikeNumber
        {
            get
            {
                int reactDislikeCount = 0;
                foreach (var reactItem in reactList)
                {
                    if (reactItem.react_React == -1)
                    {
                        reactDislikeCount++;
                    }
                }
                return reactDislikeCount;
            }
            set { idea_ReactDislikeNumber = value; }
        }
        
    }
}
