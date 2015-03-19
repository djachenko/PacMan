using System;
using PacMan.Helpers;
using PacMan.Model.Entities;

namespace PacMan.Model.Cells
{
	internal abstract class Cell : ICell
	{
	    public CellType Type { get; private set; }
	    public abstract bool AbleToMove { get; }

	    private IEntity _owner;
	    private int _x;
	    private int _y;

	    public IEntity Owner
		{
	        protected get { return _owner; }
			set
			{
				if (Owner == null)
				{
					_owner = value;
				}
				else
				{
					throw new ArgumentException("Reassigning cell's owner");
				}
			}
		}

	    internal IField Field { get; private set; }

	    public int X
	    {
	        get { return _x; }
	        protected set
	        {
	            _x = value;
                CoordinatesChanged.Raise(this);
	        }
	    }

	    public int Y
	    {
	        get { return _y; }
	        protected set
	        {
	            _y = value;
                CoordinatesChanged.Raise(this);
	        }
	    }

	    public event EventHandler CoordinatesChanged;
	    public event EventHandler RepresentationChanged;
	    public event EventHandler<MoveEventArgs> Movement;

		protected Cell(IField field, int x, int y, CellType type)
		{
			Field = field;

			X = x;
			Y = y;
		    Type = type;
		}

	    public virtual void NotifyMovement(Direction direction, IEntity caller)
		{
			if (caller == null)
			{
				throw new ArgumentNullException("caller");
			}

			if (Owner != null)
			{
                caller.Interact(Owner);
			}
		}

	    public void Teleport(int x, int y)
	    {
            X = x;
            Y = y;
	    }

	    public abstract char GetRepresentation();

	    public void OnRepresentationChanged()
        {
            RepresentationChanged.Raise(this);
        }

	    protected void OnMovement(Direction direction)
	    {
	        Movement.Raise(this, new MoveEventArgs { Direction = direction });
	    }
	}
}
