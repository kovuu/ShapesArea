namespace ShapesArea2.Shapes;

public class Triangle : IShape
{
    public Triangle(int a, int b, int c)
    {
        A = a;
        B = b;
        C = c;
    }

    private int A { get; }

    private int B { get; }

    private int C { get; }

    
    public double GetArea()
    {
        double halfPerimeter = GetPerimeter() / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
    }

    public bool IsRightTriangle()
    {
        return (C * C) == (A * A) + (B * B) | (A * A) == (C * C) + (B * B) | (B * B) == (C * C) + (A * A);
    }

    private int GetPerimeter()
    {
        return A + B + C;
    }
}