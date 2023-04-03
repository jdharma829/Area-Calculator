using AreaCalculator_CodingTest.Core;
using AreaCalculator_CodingTest.Enums;

string[] inputs = await File.ReadAllLinesAsync(@"InputValues.txt");
List<Result> Results = new();
foreach(string line in inputs)
{
    List<string> parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToList();

    if (parts.Count > 1 && Enum.TryParse(parts[0].ToLower(), out ShapeType shapeType))
    {
        switch (shapeType)
        {
            case ShapeType.circle:
                if (double.TryParse(parts[1], out double diameter) && diameter > 0)
                {
                    using Shape obj = new Circle(diameter);
                    Results.Add(new Result() { ShapeName = parts[0], Area = obj.CalculateArea() });
                }
                break;

            case ShapeType.rectangle:
                if(parts.Count > 2 && double.TryParse(parts[1], out double width) && width > 0 
                    && double.TryParse(parts[2], out double height) && height > 0)
                {
                    using Shape obj = new Rectangle(width, height);
                    Results.Add(new Result() { ShapeName = parts[0], Area = obj.CalculateArea() });
                }
                break;

            case ShapeType.square:
                if (double.TryParse(parts[1], out double sideWidth) && sideWidth > 0)
                {
                    using Shape obj = new Square(sideWidth);
                    Results.Add(new Result() { ShapeName = parts[0], Area = obj.CalculateArea() });
                }
                break;

            case ShapeType.triangle:
                if (parts.Count > 2 && double.TryParse(parts[1], out double triangleWidth) && triangleWidth > 0
                     && double.TryParse(parts[2], out double triangleHeight) && triangleHeight > 0)
                {
                    using Shape obj = new Triangle(triangleWidth, triangleHeight);
                    Results.Add(new Result() { ShapeName = parts[0], Area = obj.CalculateArea() });
                }
                break;
        }
    }
}

Results.OrderByDescending(item => item.Area).ToList().ForEach(item => Console.WriteLine(item.ToString()));

Console.Read();