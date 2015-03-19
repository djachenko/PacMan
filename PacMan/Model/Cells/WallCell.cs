using System;

namespace PacMan.Model.Cells
{
    sealed class WallCell : Cell
	{
	    internal static readonly Func<IField, int, int, Cell> Creator = (field, x, y) => new WallCell(field, x, y);

	    private WallCell(IField field, int x, int y) : base(field, x, y, CellType.Landscape)
	    {
	    }

        public override bool AbleToMove
        {
            get { return false; }
        }

        public override char GetRepresentation()
		{
			return CellRepresentations.WallCellRepresentation;
		}
	}
}
