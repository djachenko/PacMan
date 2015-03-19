using System;

namespace PacMan.Model.Cells
{
    sealed class SpaceCell : Cell
	{
	    internal static readonly Func<IField, int, int, Cell> Creator = (field, x, y) => new SpaceCell(field, x, y);

	    private SpaceCell(IField field, int x, int y) : base(field, x, y, CellType.Landscape)
	    {
	    }

        public override bool AbleToMove
        {
            get { return true; }
        }

        public override char GetRepresentation()
	    {
	        return CellRepresentations.SpaceCellRepresentation;
	    }
	}
}
