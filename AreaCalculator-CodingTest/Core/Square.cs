
namespace AreaCalculator_CodingTest.Core
{
    public class Square : Shape
    {
        private double _width;

        public Square(double width)
        {
            this._width = width;
        }

        public override double CalculateArea()
        {
            return Math.Pow(_width, 2);
        }
    }
}
