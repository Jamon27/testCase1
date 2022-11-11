namespace ShapesLibrary.Core.Interface
{
    public interface IShapesFacade
    {
        double GetCircleArea(double radius);
        double GetTriangleArea(double abSide, double bcSide, double acSide);
        bool IsOrthogonalTriangle(double abSide, double bcSide, double acSide);
        double GetShapeArea(IShape shape);
    }
}
