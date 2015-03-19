using System;

namespace PacMan.Model.Cells
{
    sealed class PillCell : Cell
	{
		internal static readonly Func<IField, int, int, Cell> Creator = (field, x, y) => new PillCell(field, x, y);

		private PillCell(IField field, int x, int y) : base(field, x, y, CellType.Passive)
		{}

        public override bool AbleToMove
        {
            get { return true; }
        }

        public override char GetRepresentation()
	    {
	        return CellRepresentations.PillCellRepresentation;
	    }
    }
}
