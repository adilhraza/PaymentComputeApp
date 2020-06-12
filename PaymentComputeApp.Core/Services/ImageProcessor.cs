using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PaymentComputeApp.Core.Services
{
    public static class ImageProcessor
    {
        public static async Task<string> SetImageUrlAsync(this IFormFile imageUrl, HostingEnvironment hostingEnvironment)
        {
            var uploadDir = @"images/employee";
            var fileName = Path.GetFileNameWithoutExtension(imageUrl.FileName);
            var extension = Path.GetExtension(imageUrl.FileName);
            var webRootPath = hostingEnvironment.WebRootPath;
            fileName = DateTime.UtcNow.ToString("yymmssfff") + fileName + extension;
            var path = Path.Combine(webRootPath, uploadDir, fileName);
            await imageUrl.CopyToAsync(new FileStream(path, FileMode.Create));
            var url = "/" + uploadDir + "/" + fileName;

            return url;
        }
    }
}
