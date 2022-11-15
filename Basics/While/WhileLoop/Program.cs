using System;
namespace WhileLoop
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i=0;
            while (i<=25)
            {
                
                if (i%2==0)
                {
                    Console.WriteLine($"The even numbers are {i}");
                    
                }
                i++;
            }
            //validating number input
            int num;
            Console.WriteLine("Enter a value: ");
            bool temp=int.TryParse(Console.ReadLine(),out num);
            while(!temp)
            {
                System.Console.WriteLine("Invalid input format. Please enter the input in number format");
                temp=int.TryParse(Console.ReadLine(),out num);
            }
            Console.WriteLine($"The entered number is a valid number and the number is {num}");



        }
    }
}