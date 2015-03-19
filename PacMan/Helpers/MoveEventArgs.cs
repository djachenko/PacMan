using System;

namespace PacMan.Helpers
{
    public sealed class MoveEventArgs : EventArgs
    {
        public Direction Direction { get; set; }
    }
}
