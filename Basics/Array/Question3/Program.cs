
using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum=0;
            int size;
            Console.WriteLine("Enter the size of the array; ");
            size=int.Parse(Console.ReadLine());
            int []arr=new int[size];
            for (int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter the number: ");
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Elements in array: ");
            foreach(int number in arr)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("sum of all elements stored in array: ");
            for(int i=0;i<arr.Length;i++)
            {
                sum=sum+arr[i];
            }
            Console.WriteLine(sum);

        }
    }
}
