
using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size: ");
            size=int.Parse(Console.ReadLine());
            int []arr=new int[size];
            
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter the number: ");
                arr[i]=int.Parse(Console.ReadLine());
                

            }
            Console.WriteLine("The elements stored in the array are: ");
            foreach(int numbers in arr)
            {
                Console.WriteLine($"{numbers}");
            }
            Console.WriteLine("The values stored in reverse order: ");
            for (int i=arr.Length-1;i>=0;i--)
            {
                Console.WriteLine($" {arr[i]}");
            }
        }
    }
}