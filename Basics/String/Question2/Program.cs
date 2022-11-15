
using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter the string: ");
            string name=Console.ReadLine();
            foreach(char len in name)
            {
                System.Console.WriteLine(len);
                //System.Console.Write(len+" ");
            }
        }
    }
}