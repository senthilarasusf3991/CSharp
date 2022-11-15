using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("physics: ");
            double physics=double.Parse(Console.ReadLine());
            Console.WriteLine("Chemistry: ");
            double chemistry=double.Parse(Console.ReadLine());
            Console.WriteLine("Mathematics: ");
            double mathematics=double.Parse(Console.ReadLine());
            
            double average=((physics+chemistry+mathematics)/300)*100;
            Console.WriteLine($"Total percentage {average}");

            if (average>75)
            {
                Console.WriteLine("The candidate is Eligible for admission");

            }
            else 
            {
                Console.WriteLine("The candidate not Eligible for admission");
            }

        }
    }
    
}