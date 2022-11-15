
using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            System.Console.WriteLine("Enter the number: ");
            int check=int.Parse(Console.ReadLine());

            if(check<100)
            {
                System.Console.WriteLine("Less than 100");

            }
            else if (check>=100 && check<=200){
                System.Console.WriteLine("Between 100-200");
            }
            else{
                System.Console.WriteLine("Greater than 200");
            }

            
            
        }
    }
}