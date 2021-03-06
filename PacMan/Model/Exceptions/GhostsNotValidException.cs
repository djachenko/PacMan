﻿using System;
using System.Runtime.Serialization;

namespace PacMan.Model.Exceptions
{
    [Serializable]
    public sealed class GhostsNotValidException : Exception
    {
        public GhostsNotValidException(string message, Exception inner) : base(message, inner)
        {
        }

        private GhostsNotValidException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}
