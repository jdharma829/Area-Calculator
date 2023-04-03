
namespace AreaCalculator_CodingTest.Core
{
    public class Triangle : Shape
    {
        private double _baseWidth;
        private double _height;

        public Triangle(double baseWidth, double height)
        {
            this._baseWidth = baseWidth;
            this._height = height;
        }

        public override double CalculateArea()
        {
            return (_baseWidth * _height) / 2;
        }
    }
}
