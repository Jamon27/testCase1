namespace ShapesLibrary.Core.Interface
{
    public interface IShapesFacade
    {
        public double GetCircleArea(double radius);
        public double GetTriangleArea(double abSide, double bcSide, double acSide);
        public double IsOrthogonalTriangle(double abSide, double bcSide, double acSide);
    }
}
