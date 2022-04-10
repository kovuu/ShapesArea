using ShapesArea2.Shapes;

namespace ShapesArea2;

class Program
{
    public static void Main()
    {
        var shapeFactory = new ShapeFactory();
        var shape1 =  shapeFactory.CreateShape(4);

        Console.WriteLine(shape1.GetArea());


        var shape2 = shapeFactory.CreateShape(3, 4, 5);
        shape2.GetArea();
        Console.WriteLine(shape2.GetArea());
        if (shape2 is Triangle)
        {
            Triangle triangle = (Triangle)shape2;
            Console.WriteLine(triangle.IsRightTriangle());
        }
    }
}