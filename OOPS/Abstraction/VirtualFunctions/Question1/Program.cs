using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        AreaCalculator area=new AreaCalculator(7);
        System.Console.Write("Area is   :");
        area.Calculate();
        area.Display();
        VolumeCalculator volume=new VolumeCalculator(4,7);
        System.Console.Write("Volume is  :");
        volume.Calculate();
        volume.Display();
    }

}