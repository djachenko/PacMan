using System;
using System.Runtime.Serialization;

namespace PacMan.Model.Exceptions
{
    [Serializable]
    public sealed class PlaceOccupiedException : Exception
    {
        public PlaceOccupiedException()
        {
        }

        private PlaceOccupiedException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
