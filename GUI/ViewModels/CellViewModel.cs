using System.ComponentModel;
using PacMan.Annotations;
using PacMan.Helpers;
using PacMan.Model.Cells;

namespace GUI.ViewModels
{
    public sealed class CellViewModel : INotifyPropertyChanged
    {
        [UsedImplicitly]
        public int X
        {
            get { return Origin.X; }
        }

        [UsedImplicitly]
        public int Y
        {
            get { return Origin.Y; }
        }

        public int Value
        {
            get { return Origin.GetRepresentation(); }
        }

        public ICell Origin { get; private set; }

        public CellViewModel(ICell origin)
        {
            Origin = origin;

            origin.CoordinatesChanged += (sender, args) =>
            {
                OnPropertyChanged("X");
                OnPropertyChanged("Y");
            };

            origin.RepresentationChanged += (sender, args) => OnPropertyChanged("Value");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged.Raise(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
