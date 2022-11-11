namespace ShapesLibrary.Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(-3, 4, 5)]
        [InlineData(3, 0, 5)]
        [InlineData(3, 4, -5)]
        public void InstantiationFailedTest(double abSide, double bcSide, double acSide)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(abSide, bcSide, acSide));
        }

        [Theory]
        [InlineData(4, 1, 2)]
        [InlineData(1, 7, 5)]
        [InlineData(3, 4, 10)]
        public void IsNotTriangleTest(double abSide, double bcSide, double acSide)
        {
            Assert.Throws<InvalidOperationException>(() => new Triangle(abSide, bcSide, acSide));
        }


        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(6, 8, 10, 24)]
        public void GetAreaTest(double abSide, double bcSide, double acSide, double area)
        {
            // arrange
            Triangle triangle = new Triangle(abSide, bcSide, acSide);

            // act
            double result = triangle.GetArea();

            // assert
            Assert.Equal(result, area);
        }


        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(6, 8, 10)]
        public void IsOrthogonalTest(double abSide, double bcSide, double acSide)
        {
            // arrange
            Triangle triangle = new Triangle(abSide, bcSide, acSide);

            // act
            bool result = triangle.IsOrthogonal();

            // assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(11, 7, 6)]
        [InlineData(13, 22, 15)]
        public void IsNotOrthogonalTest(double abSide, double bcSide, double acSide)
        {
            // arrange
            Triangle triangle = new Triangle(abSide, bcSide, acSide);

            // act
            bool result = triangle.IsOrthogonal();

            // assert
            Assert.False(result);
        }
    }
}