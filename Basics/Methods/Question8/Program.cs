
using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            void mark(){
            System.Console.WriteLine("Enter a mark1: ");
            int mark1=int.Parse(Console.ReadLine());   
            System.Console.WriteLine("Enter a mark2: ");
            int mark2=int.Parse(Console.ReadLine());  
            System.Console.WriteLine("Enter a mark3: ");
            int mark3=int.Parse(Console.ReadLine());  

            int total=(mark1+mark2+mark3);
            double percentage=total/3.0;

            System.Console.WriteLine($"mark 1: {mark1}");
            System.Console.WriteLine($"mark 2: {mark2}");
            System.Console.WriteLine($"mark 3: {mark3}");
            System.Console.WriteLine($"percentage is: {percentage}");
            }

            mark();
            
            
        }
    }
}