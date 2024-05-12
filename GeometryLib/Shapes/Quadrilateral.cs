namespace GeometryLib.Shapes;

public class Quadrilateral : IShape
{
	public (double, double) Vertex1 { get; }
	public (double, double) Vertex2 { get; }
	public (double, double) Vertex3 { get; }
	public (double, double) Vertex4 { get; }

	public Quadrilateral((double, double) vertex1, (double, double) vertex2, (double, double) vertex3, (double, double) vertex4)
	{
		Vertex1 = vertex1;
		Vertex2 = vertex2;
		Vertex3 = vertex3;
		Vertex4 = vertex4;
	}

	public double CalculateArea()
	{
		//  формула Шоеляце 
		double area = Math.Abs(Vertex1.Item1 * Vertex2.Item2 + Vertex2.Item1 * Vertex3.Item2 +
		                       Vertex3.Item1 * Vertex4.Item2 + Vertex4.Item1 * Vertex1.Item2 -
		                       (Vertex2.Item1 * Vertex1.Item2 + Vertex3.Item1 * Vertex2.Item2 +
		                        Vertex4.Item1 * Vertex3.Item2 + Vertex1.Item1 * Vertex4.Item2)) / 2.0;
		return area;
	}

	public bool IsRightAngled()
	{
		double diag1 = Distance(Vertex1, Vertex3);
		double diag2 = Distance(Vertex2, Vertex4);
		return Math.Abs(diag1 - diag2) < 0.001;
	}

	private double Distance((double x, double y) p1, (double x, double y) p2)
	{
		return Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y));
	}
}