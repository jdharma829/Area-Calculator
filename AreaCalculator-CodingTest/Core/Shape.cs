namespace AreaCalculator_CodingTest.Core
{
    public abstract class Shape : IDisposable
    {
        public abstract double CalculateArea();

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
