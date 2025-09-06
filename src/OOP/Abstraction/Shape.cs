// Abstract class defines *what* should be done, not *how*
public abstract class Shape
{
    public abstract double GetArea();
}

// Concrete class provides the *how*
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}
