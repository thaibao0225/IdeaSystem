namespace IdeaSystem.Services
{
    public interface IBufferedFileUploadService
    {
        Task<bool> UploadFile(IFormFile file, string userId, string fileName);
    }
}
