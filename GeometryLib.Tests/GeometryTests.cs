using NUnit.Framework;
using GeometryLib;

namespace GeometryLib.Tests
{
	[TestFixture]
	public class GeometryTests
	{
		[Test]
		public void CircleArea_Should_Calculate_Correctly()
		{
			double radius = 5;
			double expectedArea = Math.PI * radius * radius;
			var circle = ShapeFactory.CreateCircle(radius);

		
			double actualArea = circle.CalculateArea();

		
			Assert.AreEqual(expectedArea, actualArea, 0.001);
		}

		[Test]
		public void TriangleArea_Should_Calculate_Correctly()
		{
			var triangle = ShapeFactory.CreateTriangle(3, 4, 5);
			double expectedArea = 6;

			
			double actualArea = triangle.CalculateArea();

			
			Assert.AreEqual(expectedArea, actualArea, 0.001);
		}

		[Test]
		public void RhombusArea_Should_Calculate_Correctly()
		{
			var rhombus = ShapeFactory.CreateRhombus(10, 60);
			double expectedArea = 10 * 10 * Math.Sin(Math.PI / 3); // Side squared times sine of 60 degrees

			
			double actualArea = rhombus.CalculateArea();

			Assert.AreEqual(expectedArea, actualArea, 0.001);
		}
	}
}