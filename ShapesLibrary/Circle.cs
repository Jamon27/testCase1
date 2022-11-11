namespace ShapesLibrary.Core
{
    internal class Circle : IShape
    {
        private readonly double _radius;
        public Circle(double radius)        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("Radius should be => 0!");
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
