namespace IdeaSystem.Services
{
    public class BufferedFileUploadService : IBufferedFileUploadService
    {
        public async Task<bool> UploadFile(IFormFile file, string ideaId, string fileName, string topicId)
        {
            string path = "";
            string topicIdPath = "topic-" + topicId;
            string ideaIdPath = "idea-" + ideaId;
            try
            {
                if (file != null)
                {
                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedFiles", topicIdPath, ideaIdPath));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    
                    using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }
    }
}
