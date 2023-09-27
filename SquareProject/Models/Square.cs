using System.ComponentModel;
using System.Reflection.Metadata;

namespace SquareProject.Models
{
    public class Square : INotifyPropertyChanged
    {
        private double _side;

        public event PropertyChangedEventHandler PropertyChanged;

        public double Side
        {
            get => _side;
            set
            {
                if (value > 0)
                {
                    _side = value;
                    OnPropertyChanged(nameof(Side));
                    OnPropertyChanged(nameof(Perimeter));
                    OnPropertyChanged(nameof(Area));
                    OnPropertyChanged(nameof(AllProperty));
                }
            }
        }
        public Square()
        {
            _side = 1;
        }

        public Square(double side)
        {
            if (side > 0)
                _side = side;
            else
                _side = 1;
        }

        public double Perimeter
        {
            get => 4 * _side;
        }

        public double Area
        {
            get => _side * _side;
        }

        public string AllProperty
        {
            get => $"{Side} méter a négyzet oldala.\nKerülete {Area} méter.\nTerülete {Area} négyzetméter.";
        }

        public override string ToString()
        {
            return AllProperty;
        }

        /// <summary>
        /// Megírjuk az interface szükséges metódusát. Mindig ezt kell írni
        /// </summary>
        /// <param name="property"></param>
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
