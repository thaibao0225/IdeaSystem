namespace IdeaSystem.Services
{
    public interface IBufferedFileUploadService
    {
        Task<bool> UploadFile(IFormFile file, string ideaId, string fileName, string topicId);
    }
}
