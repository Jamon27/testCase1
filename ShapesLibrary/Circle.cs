namespace ShapesLibrary.Core
{
    public class Circle : IShape
    {
        private readonly double _radius;
        public Circle(double radius)        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Radius should be => 0!");
            }

            _radius = radius;
        }

        public double GetArea()
        {
            double area = Math.PI * Math.Pow(_radius, 2);
            return area;
        }
    }
}
