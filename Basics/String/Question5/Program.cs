
using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter the string: ");
            string name1=Console.ReadLine();
            if (name.Length==name1.Length)
            {
                System.Console.WriteLine("Length of both string are equal");
                if(name==name1)
                {
                    System.Console.WriteLine("length are equal and string are equal");
                }
                else
                {
                    System.Console.WriteLine("length are equal and string are not equal");
                }
                
            }
            else{
                System.Console.WriteLine("Length are not equal");
            }
            
        }
    }
}