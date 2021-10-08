using System.IO;

namespace LiteUploadHandler
{
    public class FileUploadInfo{
      public Stream Stream{get;set;}
      public long Length{get;set;}
      public string FullName{get;set;}
      public string ContentType{get;set;}
      public string DestinationPath{get;set;}
      public string FileNameAfterUpload{get;set;}
    }
}