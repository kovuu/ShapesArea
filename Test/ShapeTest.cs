using NUnit.Framework;
using ShapesArea2.Shapes;

namespace ShapesArea2.Test;

public class ShapeTest
{
    [Test]
    public void TestShapeAreaCalculation()
    {
        IShape shape1 = new Circle(4);
        IShape shape2 = new Triangle(3,4, 5);
        Assert.AreEqual(50.26548245743669, shape1.GetArea());
        Assert.AreEqual(6, shape2.GetArea());
    }

    [Test]
    public void TestRightTriangleChecking()
    {
        Triangle shape1 = new Triangle(4,4, 5);
        Assert.AreEqual(false, shape1.IsRightTriangle());

        Triangle shape2 = new Triangle(3,4, 5);
        Assert.AreEqual(true, shape2.IsRightTriangle());
    }
}