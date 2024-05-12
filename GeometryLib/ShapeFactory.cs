using GeometryLib.Shapes;

namespace GeometryLib;

public static class ShapeFactory
{
	public static IShape CreateCircle(double radius)
	{
		return new Circle(radius);
	}
	public static IShape CreateTriangle(double sideA, double sideB, double sideC)
	{
		return new Triangle(sideA, sideB, sideC);
	}
	public static IShape CreateQuadrilateral((double, double) vertex1, (double, double) vertex2, (double, double) vertex3, (double, double) vertex4)
	{
		return new Quadrilateral(vertex1, vertex2, vertex3, vertex4);
	}
	public static IShape CreateRhombus(double sideLength, double angle)
	{
		return new Rhombus(sideLength, angle);
	}
}