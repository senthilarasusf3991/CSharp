
using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string: ");
            string name=Console.ReadLine();
            
            System.Console.WriteLine("Enter starting index: ");
            int start = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Enter number range : ");
            int range = int.Parse(Console.ReadLine());
            
            for(int i = start-1; i<start+range;i++)
            {
                System.Console.Write(name[i]);
            }
        }
    }
}