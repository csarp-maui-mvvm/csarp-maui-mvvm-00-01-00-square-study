using System.Reflection.Metadata;

namespace SquareProject.Models
{
    public class Square
    {
        private double _side;
        public double Side
        {
            get => _side;
            set
            {
                if (value > 0)
                {
                    _side = value;
                }
            }
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
    }
}
