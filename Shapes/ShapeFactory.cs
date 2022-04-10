namespace ShapesArea2.Shapes;

public class ShapeFactory
{
    public ShapeFactory() {}
    
    
    public IShape CreateShape(int radius)
    {
        return new Circle(radius);
    }

    public IShape CreateShape(int a, int b, int c)
    {
        return new Triangle(a, b, c);
    }
}