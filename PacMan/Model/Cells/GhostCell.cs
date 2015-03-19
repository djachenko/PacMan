using System;
using PacMan.Helpers;
using PacMan.Model.Entities;

namespace PacMan.Model.Cells
{
    sealed class GhostCell : Cell
	{
		internal static readonly Func<IField, int, int, Cell> Creator = (field, x, y) => new GhostCell(field, x, y);

		private GhostCell(IField field, int x, int y) : base(field, x, y, CellType.Active)
		{}

        public override bool AbleToMove
        {
            get { return false; }
        }

        public override void NotifyMovement(Direction direction, IEntity caller)
	    {
	        if (caller != Owner)
	        {
	            base.NotifyMovement(direction, caller);
	        }
	        else
	        {
	            Field.NotifyMovement(X + direction.Dx, Y + direction.Dy, direction, caller);

	            if (Field.AbleToMove(X + direction.Dx, Y + direction.Dy))
	            {
	                Field.RelocateCell(this, X + direction.Dx, Y + direction.Dy);
	                
	                X += direction.Dx;
	                Y += direction.Dy;

	                OnMovement(direction);
	            }
	        }
	    }

	    public override char GetRepresentation()
	    {
	        return CellRepresentations.GhostCellRepresentation;
	    }
	}
}
