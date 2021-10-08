using System;
using System.Linq;
using LiteUploadHandler.FileUploadExceptions;

namespace LiteUploadHandler
{
    internal static class FileValidator
    {
        public static bool IsValid(this FileUploadInfo file, ValidationConfigInfo cfg)
        {
            if (!file.ContentType.isValidContentType(cfg.ValidContentTypes))
                throw new InvalidContentTypeException($"Invalid Content Type: {file.ContentType}");

            if (!file.FullName.isValidExtensions(cfg.ValidExtensions))
                throw new InvalidFileExtenssionException($"Invalid File Extension: {file.FullName}");

            if (!file.Length.isValidFileSize(cfg.MaxFileSizeInKb))
                throw new InvalidFileSizeException($"Invalid File size: {file.Length.ToString()}");

            return true;
        }

        private static bool isValidFileSize(this long length, long maxFileSizeInKb)
        {
            var validSize = maxFileSizeInKb * 1024;

            return length < validSize;
        }

        private static bool isValidExtensions(this string fullName, string[] validExtensions)
        {
            var extension = System.IO.Path.GetExtension(fullName);

            return validExtensions.Contains(extension);
        }

        private static bool isValidContentType(this string contentType, string[] validContentTypes)
        {
            return validContentTypes.Contains(contentType);
        }
    }
}