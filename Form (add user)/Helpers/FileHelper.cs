using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace Form__add_user_.Helpers
{
    public class FileHelper
    {

        private readonly IWebHostEnvironment _webHost;

        public FileHelper(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }

        public async Task<string> SaveFile(IFormFile file)
        {

            var saveimg = Path.Combine(_webHost.WebRootPath, "images", file.FileName);

            using (var img = new FileStream(saveimg, FileMode.Create))
            {
                await file.CopyToAsync(img);
            }



            return file.FileName;
        }

    }
}
