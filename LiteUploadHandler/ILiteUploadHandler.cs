using System;
using System.Threading;
using System.Threading.Tasks;

namespace LiteUploadHandler
{
    public interface ILiteUploadHandler
    {
        Task<string> Upload(FileUploadInfo uploadInfo, CancellationToken cancellationToken);
    }

}