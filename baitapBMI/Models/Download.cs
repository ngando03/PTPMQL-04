using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace tinhchisoMBI.Helpers
{
    public class Download
    {
        public static async Task<FileResult> DownloadFileAsync(string filePath, string contentType = "application/octet-stream")
        {
            if (!System.IO.File.Exists(filePath))
                return null;

            var memory = new MemoryStream();
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;

            var fileName = Path.GetFileName(filePath);
            return new FileStreamResult(memory, contentType)
            {
                FileDownloadName = fileName
            };
        }
    }
}
