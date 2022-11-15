using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        
        Cylinders cylinder =new Cylinders(2.5,3.2);
        System.Console.WriteLine("-----cylinder-------");
        cylinder.CalculateArea();
        System.Console.WriteLine("Area is "+cylinder.Area);
        cylinder.CalculateVolume();
        System.Console.WriteLine("volume is "+cylinder.Volume);
        Cubes cube=new Cubes(7.7);
        cube.CalculateArea();
        System.Console.WriteLine("--------Cube--------");
        System.Console.WriteLine("Area is "+cube.Area);
        cube.CalculateVolume();
        System.Console.WriteLine("Volume is "+cube.Volume);
    }
}