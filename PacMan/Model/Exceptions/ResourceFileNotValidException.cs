using System;
using System.Runtime.Serialization;

namespace PacMan.Model.Exceptions
{
    [Serializable]
    public sealed class ResourceFileNotValidException : Exception
    {
        public ResourceFileNotValidException(string message, Exception inner) : base(message, inner)
        {
        }

        private ResourceFileNotValidException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
