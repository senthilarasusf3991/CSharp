using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature: ");
            int temperature=int.Parse(Console.ReadLine());
            if (temperature<0)
            {
                Console.WriteLine($"{temperature} is Freezing Weather");

            }
            else if (temperature>0 && temperature<10)
            {
                Console.WriteLine($"{temperature} is Very cold Weather");
            }
            else if (temperature>10 && temperature<20)
            {
                Console.WriteLine($"{temperature} is cold Weather");
            }
            else if (temperature>20 && temperature<30)
            {
                Console.WriteLine($"{temperature} is normal in Temp");
            }
            else if (temperature>30 && temperature<40)
            {
                Console.WriteLine($"{temperature} is It's Hot");
            }
            else if (temperature>=40)
            {
                Console.WriteLine($"{temperature} It's very Hot");
            }
            else
            {
                Console.WriteLine($"{temperature} is invalid");
            }
        }
    }
}