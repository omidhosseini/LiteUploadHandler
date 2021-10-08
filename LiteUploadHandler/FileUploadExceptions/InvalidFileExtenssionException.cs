using System;
using System.Runtime.Serialization;

namespace LiteUploadHandler.FileUploadExceptions
{
    public class InvalidFileExtenssionException : Exception
    {
        public InvalidFileExtenssionException()
        {
        }

        public InvalidFileExtenssionException(string message) : base(message)
        {
        }

        public InvalidFileExtenssionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidFileExtenssionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}