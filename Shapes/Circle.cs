namespace ShapesArea2.Shapes;

public class Circle : IShape
{
    private readonly int _radius;

    public Circle()
    {
        _radius = 0;
    }
    
    public Circle(int radius)
    {
        _radius = radius;
    }
    
    public double GetArea()
    {
        return Math.PI * (_radius * _radius);
    }
}