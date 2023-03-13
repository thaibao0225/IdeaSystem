namespace IdeaSystem.Services
{
    public class BufferedFileUploadService : IBufferedFileUploadService
    {
        public async Task<bool> UploadFile(IFormFile file, string userId, string fileName)
        {
            string path = "";
            try
            {
                if (file != null)
                {
                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedFiles"));
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
