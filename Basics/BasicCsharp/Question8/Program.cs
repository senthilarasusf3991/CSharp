using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the value : ");
            double meter=double.Parse(Console.ReadLine());

            double cm =meter*100;
            double mm = cm*10;
            double inch= 39.3*meter;
            double foot= 12*meter;
            double mile= 0.0006213715277778*meter;

            Console.WriteLine($"{meter} meter is {cm} cm");
            Console.WriteLine($"{meter} meter is {mm} mm");
            Console.WriteLine($"{meter} meter is {inch} inch");
            Console.WriteLine($"{meter} meter is {foot} foot");
            Console.WriteLine($"{meter} meter is {mile} mile");

            Console.ReadLine();

        

        }
    }
}