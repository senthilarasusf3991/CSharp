using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed in km/hr: ");
            int speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            int distancetravelled=speed*seconds*5/18;
            Console.WriteLine($"Distance Travelled is {distancetravelled} Meters");
            Console.WriteLine();

        }
    }
}
