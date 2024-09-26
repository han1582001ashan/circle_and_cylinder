public class Cylinder : Circle
{
    private double height;

    public Cylinder()
    {

    }
    public Cylinder(double radius, string color, double height) : base(radius, color)
    {
        this.height = height;

    }
    public void setHeight(double height)
    {
        this.height = height;
    }
    public double getHeight()
    {
        return this.height;
    }
    public double getVolume()
    {
        return getRadius() * getRadius() * Math.PI * getHeight();
    }
    public override string ToString()
    {
        return "A Cylinder with radius="

                    + getRadius()
                    + "and height= "
                    + getHeight()
                    +"\n Area:"
                    +getArea()
                    +"\n Volume"
                    +getVolume();
    }

}