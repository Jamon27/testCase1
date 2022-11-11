namespace ShapesLibrary.Core
{
    public class Triangle : IShape
    {
        private readonly double _abSide;
        private readonly double _bcSide;
        private readonly double _acSide;
        public Triangle(double ABSide, double BCSide, double ACSide)
        {
            if (ABSide <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ABSide), "Side of triangle must be positive value");
            }

            if (BCSide <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(BCSide), "Side of triangle must be positive value");
            }

            if (ACSide <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ACSide), "Side of triangle must be positive value");
            }

            if (ABSide + BCSide < ACSide || BCSide + ACSide < ABSide || ABSide + ACSide < BCSide)
            {
                throw new InvalidOperationException("Can not create triangle! Please, check the sides length.");
            }

            _abSide = ABSide;
            _bcSide = BCSide;
            _acSide = ACSide;
        }

        public double GetArea()
        {
            double halfPerimeter = GetPerimeter(_abSide, _bcSide, _acSide) / 2;

            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - _abSide) * (halfPerimeter - _bcSide) * (halfPerimeter - _acSide));
            return area;
        }

        public bool IsOrthogonal()
        {
            return HasOrthogonalAngle(_abSide, _bcSide, _acSide);
        }

        private double GetPerimeter(double ABSide, double BCSide, double ACSide)
        {
            double perimeter = ABSide + BCSide + ACSide;
            return perimeter;
        }

        private bool HasOrthogonalAngle(params double[] sides)
        {
            bool isOrthogonal = false;
            double longestSide = sides.Max();

            if (sides.Select(x => x == longestSide).Count() > 1)
            {
                isOrthogonal = false;
            }
            else
            {
                isOrthogonal = sides.Where(x => x != longestSide).Sum(x => Math.Pow(x, 2)) == Math.Pow(longestSide, 2);
            }

            return isOrthogonal;
        }
    }
}
