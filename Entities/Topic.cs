namespace IdeaSystem.Entities
{
    public class Topic
    {
        public string topic_Id { get; set; }
        public string topic_Name { get; set; }
        public DateTime topic_ClosureDate { get; set; }
        public DateTime topic_FinalClosureDate { get; set; }

        public ICollection<Idea> ideaList { get; set; }

    }
}
