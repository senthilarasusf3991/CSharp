using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the price amount: ");
            double price=double.Parse(Console.ReadLine());
            double total= price+(price*0.18);

            Console.WriteLine($"Total Price amount of the product {total}");
            Console.ReadLine();

        }
    }
}