using ShapesLibrary.Core.Interface;
using ShapesLibrary.Core.Shapes;

namespace ShapesLibrary.Core
{
    public class ShapesFacade : IShapesFacade
    {
        public double GetCircleArea(double radius)
        {
            Circle circle = new Circle(radius);
            return circle.GetArea();
        }

        public double GetTriangleArea(double abSide, double bcSide, double acSide)
        {
            Triangle triangle = new Triangle(abSide, bcSide, acSide);
            return triangle.GetArea();
        }

        public bool IsOrthogonalTriangle(double abSide, double bcSide, double acSide)
        {
            Triangle triangle = new Triangle(abSide, bcSide, acSide);
            return triangle.IsOrthogonal();
        }

        public double GetShapeArea(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
