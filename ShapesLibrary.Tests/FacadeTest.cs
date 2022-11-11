namespace ShapesLibrary.Tests
{
    public class FacadeTest
    {
        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(3, 9 * Math.PI)]
        [InlineData(5, 25 * Math.PI)]
        public void GetCircleShapeAreaTest(double radius, double area)
        {
            // arrange
            ShapesFacade shapesFacade = new ShapesFacade();
            Circle circle = new Circle(radius);

            // act
            double result = shapesFacade.GetShapeArea(circle);

            // assert
            Assert.Equal(result, area);
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(6, 8, 10, 24)]
        public void GetTriangleShapeAreaTest(double abSide, double bcSide, double acSide, double area)
        {
            // arrange
            ShapesFacade shapesFacade = new ShapesFacade();
            Triangle triangle = new Triangle(abSide, bcSide, acSide);

            // act
            double result = shapesFacade.GetShapeArea(triangle);

            // assert
            Assert.Equal(result, area);
        }
    }
}
