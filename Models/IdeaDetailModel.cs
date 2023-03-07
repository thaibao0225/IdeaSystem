namespace IdeaSystem.Models
{
    public class IdeaDetailModel
    {
        public string idea_Id { get; set; }
        public string idea_Text { get; set; }
        public DateTime idea_CreateOn { get; set; }
        public string idea_FilePath { get; set; }
        public string idea_UserId { get; set; }
        public string idea_UserName { get; set; }
        public string idea_TopicId { get; set; }
        public string idea_TopicName { get; set; }
        public string idea_CategoryId { get; set; }
        public string idea_CategoryName { get; set; }
        public DateTime idea_Deadline1 { get; set; }
        public DateTime idea_Deadline2 { get; set; }
    }
}
