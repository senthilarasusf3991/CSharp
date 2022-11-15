
using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int temp=0;
            System.Console.WriteLine("Enter the string: ");
            string name=Console.ReadLine();
            string[] splita=name.Split(" ");
            foreach(string len in splita)
            {
                temp++;
                
            }
            System.Console.WriteLine(temp);
            System.Console.WriteLine(splita.Length);

        }
    }
}