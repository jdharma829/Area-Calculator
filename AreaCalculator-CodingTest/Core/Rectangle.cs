
namespace AreaCalculator_CodingTest.Core
{
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            this._width = width;
            this._height = height;
        }

        public override double CalculateArea()
        {
            return _width * _height;
        }
    }
}
