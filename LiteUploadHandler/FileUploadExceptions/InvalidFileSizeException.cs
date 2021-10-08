using System;
using System.Runtime.Serialization;

namespace LiteUploadHandler.FileUploadExceptions
{
    public class InvalidFileSizeException : Exception
    {
        public InvalidFileSizeException()
        {
        }

        public InvalidFileSizeException(string message) : base(message)
        {
        }

        public InvalidFileSizeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidFileSizeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}