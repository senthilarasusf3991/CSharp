
using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("enter the string: ");
            string name=Console.ReadLine();
            for(int i=name.Length-1;i>=0;i--)
            {
                System.Console.Write(name[i]+" ");
            }
        }
    }
}