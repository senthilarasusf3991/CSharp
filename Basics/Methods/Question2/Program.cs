
using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            void define(string a,string b)
            {
                System.Console.WriteLine(a);
                System.Console.WriteLine(b);

                
            }

            System.Console.WriteLine("Enter a string: ");
            string string1=Console.ReadLine();
            System.Console.WriteLine("Enter a string: ");
            string string2=Console.ReadLine();
            
            define(string1,string2);
        }
    }
}