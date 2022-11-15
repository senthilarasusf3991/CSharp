using System;
namespace Dowhile
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            string condition="";   
            do
            {
            
                Console.WriteLine("Enter the number: ");
                int number=int.Parse(Console.ReadLine());
                if (number%2==0)
                {
                    Console.WriteLine($"{number} is even number");
                }
                else
                {
                    Console.WriteLine($"{number} is odd number");

                }
                Console.WriteLine("Do you want to repeat: ");
                condition=Console.ReadLine();

                while (condition!="yes" && condition!="no")
                {
                    Console.WriteLine("Wrong input enter valid input... Enter either yes or no");
                    condition=Console.ReadLine();
                    
                }
          
            }while(condition=="yes");
            
        }

    }
}
