using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        CircleCalculator circle=new CircleCalculator(10);
        circle.Area();
        CylinderCalculator cylinder=new CylinderCalculator(10,12);
        cylinder.Area();
        cylinder.Volume();
    }
}