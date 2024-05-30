using Shapes_And_Formulas.Shapes.BasicShapes;
using System.Globalization;

namespace Tests_For_Shapes_And_Formulas
{
    [TestClass]
    public class BasicShapesTestsWithInvariantCulture
    {
        [TestInitialize]
        public void InitializeTestClass()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
        }

        [TestMethod]
        public void Circle_Area_Has_Right_Formula()
        {
            // Arrange
            double radius = 10;
            Circle circle = new() 
            { Radius = radius };

            // Act
            double circleArea = circle.Area;

            // Assert
            double actualArea = double.Pi * radius * radius;
            Assert.AreEqual(actualArea, circleArea, 0.001, "Повреждена формула площади круга");
        }

        [TestMethod]
        public void Triangle_Area_Has_Right_Formula()
        {
            // Arrange
            double a = 6;
            double b = 6;
            double c = 10;

            Triangle triangle = new()
            { 
                A = a,
                B = b,
                C = c
            };

            // Act
            double triangleArea = triangle.Area;

            // Assert
            double halfPerimeter = (a + b + c) / 2;
            double actualArea = Math.Sqrt(halfPerimeter*(halfPerimeter-a)*(halfPerimeter-b)*(halfPerimeter-c));

            Assert.AreEqual(actualArea, triangleArea, 0.001, "Повреждена формула площади треугольника");
        }
    }
}