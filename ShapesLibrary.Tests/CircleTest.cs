namespace ShapesLibrary.Tests
{
    public class CircleTest
    {
        [Theory]
        [InlineData(-1)]
        public void InstantiationFailedTest(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        [Theory]
        [InlineData(1, 1 * Math.PI)]
        [InlineData(5, 25 * Math.PI)]
        [InlineData(10, 100 * Math.PI)]
        public void GetAreaTest(double radius, double area)
        {
            // arrange
            Circle circle = new Circle(radius);

            // act
            double result = circle.GetArea();

            // assert
            Assert.Equal(result, area);
        }
    }
}