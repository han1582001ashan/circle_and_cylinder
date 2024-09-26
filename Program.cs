using System;
namespace SystemTime
{
    class Program{
        static void Main(string[] args){
            Circle circle = new Circle();
            circle.setColor("red");
            circle.setRadius(30.5);
            Cylinder cylinder=new Cylinder(30.5, "yellow", 70.2);
            Console.WriteLine(circle.ToString());
            Console.WriteLine(cylinder.ToString());
        }
    }
}
