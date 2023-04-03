
namespace AreaCalculator_CodingTest.Core
{
    public class Circle : Shape
    {
        private double _diameter;

        public Circle(double diameter)
        {
            this._diameter = diameter;
        }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI * Math.Pow(_diameter/2, 2), 2);
        }
    }
}
