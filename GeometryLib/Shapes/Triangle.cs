namespace GeometryLib.Shapes;

public class Triangle : IShape
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        double s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightAngled()
    {
        double a = SideA, b = SideB, c = SideC;
        double[] sides = new[] { a, b, c };
        Array.Sort(sides);
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 0.001;
    }
}