
using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter the length of a side of the ground: ");
            double length=double.Parse(Console.ReadLine());
            System.Console.Write("Enter the width of the tile: ");
            double WidthOfTile=double.Parse(Console.ReadLine());
            System.Console.Write("Enter the length of the tile: ");
            double lengthOfTile=double.Parse(Console.ReadLine());
            System.Console.Write("Enter the Width of bench: ");
            double widthOfBench=double.Parse(Console.ReadLine());
            System.Console.Write("Enter the length of bench: ");
            double lenghOfBench=double.Parse(Console.ReadLine());
            double areaOfGround=length*length;
            double areaOfTile=lengthOfTile*WidthOfTile;
            double areaOfBench=lenghOfBench*widthOfBench;
            double tile=(areaOfGround-areaOfBench)/areaOfTile;
            System.Console.WriteLine($"Number of tiles needed needed : {tile}");
            System.Console.WriteLine($"Time required to change the tile: {tile*0.2}");

            
        }
    }
}
