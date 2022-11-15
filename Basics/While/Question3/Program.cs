
using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int series=int.Parse(Console.ReadLine());
            int i=1;
            int a=0;
            int b=1;
            int temp=0;

            while(i<=series)
            {
                Console.WriteLine(a);
                
                
                temp=a+b;
                a=b;
                b=temp;
                i++;


            }

            

        }
    }
}