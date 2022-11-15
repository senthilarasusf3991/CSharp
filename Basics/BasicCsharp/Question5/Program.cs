using System;
namespace Question5
{
    class Prgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Physics mark: ");
            double Physics = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the chemistry mark: ");
            double chemistry = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the maths mark: ");
            double maths = double.Parse(Console.ReadLine());

            double sum= (Physics+chemistry+maths);
            double percentage = sum*100/300;
        

            Console.WriteLine($"sum is {sum}");
            Console.WriteLine($"percentage is {percentage}");

            Console.ReadLine();



        }
    }
}