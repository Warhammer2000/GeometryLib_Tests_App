using GeometryLib;

namespace GeometryApp 
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IShape circle = ShapeFactory.CreateCircle(5);
			Console.WriteLine("Площадь круга: " + circle.CalculateArea());

		
			IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
			Console.WriteLine("Площадь треугольника: " + triangle.CalculateArea());

			
			IShape quadrilateral = ShapeFactory.CreateQuadrilateral((0, 0), (4, 0), (4, 3), (0, 3));
			Console.WriteLine("Площадь четырехугольника: " + quadrilateral.CalculateArea());

		
			Console.WriteLine("Площадь через универсальный метод: " + CalculateShapeArea(quadrilateral));
		}
		public static double CalculateShapeArea(IShape shape)
		{
			return shape.CalculateArea();
		}
	}
}