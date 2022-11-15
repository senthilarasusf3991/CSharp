
using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size: ");
            size=int.Parse(Console.ReadLine());
            int []num=new int [size];
            
            for(int i=0;i<num.Length;i++)
            {
                Console.WriteLine("Enter the number: ");
                num[i]=int.Parse(Console.ReadLine());
                
                
            }
            Console.WriteLine("Elements in array are: ");
            foreach (int number in num)
            {
                Console.WriteLine($" {number}  ");
            }
            
        }
    }
}