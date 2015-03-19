using System;
using PacMan.Helpers;
using PacMan.Model.Entities;

namespace PacMan.Model.Cells
{
    public interface ICell
    {
        CellType Type { get; }
        bool AbleToMove { get; }
        int X { get; }
        int Y { get; }
        IEntity Owner { set; }
        void NotifyMovement(Direction direction, IEntity caller);
        void Teleport(int toX, int toY);
        void OnRepresentationChanged();
        event EventHandler<MoveEventArgs> Movement;
        event EventHandler CoordinatesChanged;
        event EventHandler RepresentationChanged;
        char GetRepresentation();
    }
}