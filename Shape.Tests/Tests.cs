using Shapes;
using Xunit;

namespace Shape.Tests
{
 
    public class TriangleTests
    {
        [Fact]
        public void IsStraightTriangle_ReturnFalse()
        {
            //Arrange
            var triangle = new Triangle("Треугольник", 2, 3, 4);

            //Act
            var result = triangle.IsStraightTriangle();

            //Assert
            Assert.False(result);
        }

        [Fact]
        public void Square()
        {
            //Arrange
            var triangle = new Triangle("Треугольник", 3, 4, 5);
            double expected = 6;

            //Act
            var result = triangle.Square();

            //Assert
            Assert.Equal(expected, result);
        }
    }

 
    public class CircleTest
    {
        [Fact]
        public void Square()
        {
            //Arrange
            var circle = new Circle("Круг", 5);
            double expected = 78.5;

            //Act
            var result = circle.Square();

            //Assert
            Assert. Equal(expected, result);
        }
    }
}
