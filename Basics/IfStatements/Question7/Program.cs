using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter customer id: ");
            double customerid=double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter name: ");
            string name=(Console.ReadLine());
            
            Console.WriteLine("Enter unit consumed: ");
            double unitconsumed=double.Parse(Console.ReadLine());
            

            double amount;
            

            if(unitconsumed<=199)
            {
                amount=unitconsumed*1.20;
                Console.WriteLine($"Amount charges @rupees 1.20 per unit:{amount}");
            }
            else if(unitconsumed>200 && unitconsumed<400 )
            {
                 amount=unitconsumed*1.50;
                Console.WriteLine($"Amount charges @rupees 1.50 per unit:{amount}");
            }
            else if(unitconsumed>400 && unitconsumed<600 )
            {
                 amount=unitconsumed*1.80;
                Console.WriteLine($"Amount charges @rupees 1.80 per unit:{amount}");
            }
            else 
            {
                amount=unitconsumed*2.00;
                Console.WriteLine($"Amount charges @rupees 2.00 per unit:{amount}");
            }
            double tax=0;
            if (unitconsumed>400)
            
            {
                
                tax=amount*0.15;

            }
          
            
            if (amount<100)
            {
                Console.WriteLine("Minimum bill amount is Rs 100");
            }
            
            Console.WriteLine($"Customer IDNO:{customerid}");
            Console.WriteLine($"Customer Name:{name}");
            Console.WriteLine($"unitconsumed :{unitconsumed}");
            Console.WriteLine($"surcharge amount: {tax}");
            Console.WriteLine($"The net amount to be paid by the customer {amount+tax}");  
        }
    }
}
