
using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number: ");
            int num;
            bool temp=int.TryParse(Console.ReadLine(),out num);
            while(temp==false)
            {
                System.Console.WriteLine("Invalid inpur enter the number again: ");
                temp=int.TryParse(Console.ReadLine(),out num);
            }
            if (num>1 && num<5)
            {
                System.Console.WriteLine("Valid input {num} in range between 1-5");
            }
            else
            {
                System.Console.WriteLine("Valid input {num} not in range between 1-5");
            }

        }
    }
}