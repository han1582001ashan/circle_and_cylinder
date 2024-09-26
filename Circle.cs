using System.Dynamic;

public class Circle
{
    private double radius;
    private string color;

    public Circle()
    {

    }
    public Circle(double radius, string color)
    {

        this.color = color;
        this.radius = radius;
    }
    public void setRadius(double radius)
    {
        this.radius = radius;
    }
    public double getRadius()
    {
        return this.radius;
    }
    public void setColor(string color)
    {
        this.color = color;
    }
    public string getColor()
    {
        return this.color;
    }
    public double getArea()
    {
        return radius * radius * Math.PI;
    }
    public override string ToString()
    {
        return "A Circle with radius="

                    + getRadius()

                    + ": Area is "
                    + getArea();
    }
}