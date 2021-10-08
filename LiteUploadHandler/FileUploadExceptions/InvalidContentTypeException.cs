using System;
using System.Runtime.Serialization;

namespace LiteUploadHandler.FileUploadExceptions
{
    public class InvalidContentTypeException : Exception
    {
        public InvalidContentTypeException()
        {
        }

        public InvalidContentTypeException(string message) : base(message)
        {
        }

        public InvalidContentTypeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidContentTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}