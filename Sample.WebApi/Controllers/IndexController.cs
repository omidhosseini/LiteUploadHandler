using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web;
using Microsoft.AspNetCore.Http;
using LiteUploadHandler;
using System.Threading;

namespace Sample.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IndexController : ControllerBase
    {
        private readonly ILiteUploadHandler uploadManager;

        public IndexController(ILiteUploadHandler uploadManager)
        {
            this.uploadManager = uploadManager;
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(IFormFile file, CancellationToken cancellationToken)
        {
            try
            {
                var res = await this.uploadManager.Upload(new FileUploadInfo
                {
                    ContentType = file.ContentType,
                    DestinationPath = "images",
                    FileNameAfterUpload = $"{Guid.NewGuid()}.{file.FileName}",
                    FullName = file.FileName,
                    Length = file.Length,
                    Stream = file.OpenReadStream()
                }, cancellationToken);
                return Ok(res);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
