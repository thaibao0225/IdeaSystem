using IdeaSystem.Data;
using IdeaSystem.Models;

namespace IdeaSystem.Services
{
    public interface IManuallyTopicToTopicModel
    {
        public TopicModel TransferToTopicModel(string topicId);
        public IdeaDetailModel TransferToIdeaDetailModel(string topicId);
    }
}
