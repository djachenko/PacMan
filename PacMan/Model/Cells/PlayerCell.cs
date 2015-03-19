using System;
using PacMan.Helpers;
using PacMan.Model.Entities;

namespace PacMan.Model.Cells
{
    sealed class PlayerCell : Cell
    {
		internal static readonly Func<IField, int, int, Cell> Creator = (field, x, y) => new PlayerCell(field, x, y);

		private PlayerCell(IField field, int x, int y) : base(field, x, y, CellType.Active)
		{}

        public override bool AbleToMove
        {
            get { return false; }
        }

        public override void NotifyMovement(Direction direction, IEntity caller)
        {
		    if (caller == Owner)
		    {
                Field.NotifyMovement(X + direction.Dx, Y + direction.Dy, direction, caller);

                if (Owner.Alive && Field.AbleToMove(X + direction.Dx, Y + direction.Dy))
		        {
                    Field.RelocateCell(this, X + direction.Dx, Y + direction.Dy);

		            X += direction.Dx;
		            Y += direction.Dy;

		            OnMovement(direction);
		        }
		    }
		    else
		    {
                base.NotifyMovement(direction, caller);
		    }
        }

	    public override char GetRepresentation()
		{
			return Owner != null && ((Player) Owner).High ? 
                CellRepresentations.HighPlayerCellRepresentation : 
                CellRepresentations.PlayerCellRepresentation;//to show whether player is high or not
		}
    }
}
	