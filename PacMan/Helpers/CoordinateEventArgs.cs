using System;

namespace PacMan.Helpers
{
    public sealed class CoordinateEventArgs : EventArgs
    {
        public object CellRemoved { get; internal set; }
        public object CellAdded { get; internal set; }
    }
}
