
namespace LiteUploadHandler
{
    public class ValidationConfigInfo
    {
        public string[] ValidContentTypes { get; set; }
        public string[] ValidExtensions { get; set; }
        public long MaxFileSizeInKb { get; set; }
    }
}