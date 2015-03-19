using System;
using System.Runtime.Serialization;

namespace PacMan.Model.Exceptions
{
    [Serializable]
    public sealed class KeyBindedException : Exception
    {
        public KeyBindedException(string message) : base(message)
        {
        }

        private KeyBindedException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
