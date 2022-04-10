using ShapesArea2.Shapes;

namespace ShapesArea2;

class Program
{
    public static void Main()
    {
        var shapeFactory = new ShapeFactory();
        var shape1 =  shapeFactory.CreateShape(4);

        Console.WriteLine("Площадь круга: " + shape1.GetArea());

        var shape2 = shapeFactory.CreateShape(3, 4, 5);
        Console.WriteLine("Площадь треугольника: " + shape2.GetArea());
        if (shape2 is Triangle triangle)
        {
            Console.WriteLine("Треугольник прямоугольный:" + triangle.IsRightTriangle());
        }
    }
}