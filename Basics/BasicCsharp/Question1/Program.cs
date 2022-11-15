using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the word Hello: ");
            string hello=Console.ReadLine();
            Console.WriteLine("Enter the name: ");
            string name1=Console.ReadLine();
            //concatination
            Console.WriteLine(hello+": "+name1);
            //Place holder
            Console.WriteLine("{0}: {1}",hello,name1);
            //interpolation
            Console.WriteLine($"{hello}: {name1}");



            Console.ReadLine();
        }
    }
}