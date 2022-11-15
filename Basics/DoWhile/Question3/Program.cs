
using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int range;
            System.Console.WriteLine("Enter the range: ");
            range=int.Parse(Console.ReadLine());
            
            
            int i=1;
            int a=0;
            int b=1;
            int temp=0;
            do
            {
            
                
                System.Console.WriteLine(a);
                temp=a+b;
                a=b;
                b=temp;
                i++;
                


            }while(i<=range);
            
        }
    }
}