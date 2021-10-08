using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace LiteUploadHandler
{
    internal class LiteUploadHandler : ILiteUploadHandler
    {
        private readonly ValidationConfigInfo _config;

        public LiteUploadHandler(ValidationConfigInfo config)
        {
            _config = config;
        }

        public async Task<string> Upload(FileUploadInfo uploadInfo, CancellationToken cancellationToken)
        {
            uploadInfo.IsValid(_config);

            var destinationPath = $"{uploadInfo.DestinationPath}/{uploadInfo.FileNameAfterUpload}";
            using (var fs = new FileStream(destinationPath, FileMode.CreateNew))
            {
                await uploadInfo.Stream.CopyToAsync(fs, cancellationToken);
            }

            return destinationPath;
        }
    }

}