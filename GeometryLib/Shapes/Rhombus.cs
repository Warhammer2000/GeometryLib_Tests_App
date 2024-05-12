namespace GeometryLib.Shapes;

public class Rhombus : IShape
{
	public double SideLength { get; }
	public double Angle { get; }  

	public Rhombus(double sideLength, double angle)
	{
		SideLength = sideLength;
		Angle = angle;
	}

	public double CalculateArea()
	{
		double angleRadians = Angle * Math.PI / 180;  
		return SideLength * SideLength * Math.Sin(angleRadians);
	}

	public bool IsRightAngled()
	{
		return Math.Abs(Angle - 90) < 0.001 || Math.Abs(Angle - 270) < 0.001;
	}
}