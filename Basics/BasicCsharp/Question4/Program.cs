using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            double height = double.Parse(Console.ReadLine());

            double volumeofcylinder=3.14*radius*radius*height;
            Console.WriteLine($"Volume of cylinder is {volumeofcylinder}");
            Console.WriteLine();

        }
    }
}
