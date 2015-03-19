using PacMan.Helpers;
using PacMan.Model.Cells;
using PacMan.Model.Entities;
using PacMan.Model.Entities.Ghosts;

namespace PacMan.Model
{
    public interface IField
    {
        void NotifyMovement(int x, int y, Direction direction, IEntity caller);
        bool AbleToMove(int x, int y);
        void RelocateCell(ICell cell, int toX, int toY);
        void RemovePassiveCell(int x, int y);
        void ResetActiveCell(int x, int y, int initialX, int initialY);
        int Width { get; }
        int Height { get; }
        Labyrinth Labyrinth { get; }
    }
}
