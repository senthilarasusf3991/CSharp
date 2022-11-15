
using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size: ");
            size=int.Parse(Console.ReadLine());
            int []arr=new int [size];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter the number: ");
                arr[i]=int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The even numbers are: ");
            for(int i=0;i<arr.Length;i++)  //using for
            {
                
                if (arr[i]%2==0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.WriteLine("The odd numbers are: ");
            foreach(int number in arr)    //foreach method
            {
                if (number%2==1)
                {
                    Console.WriteLine(number);
                }
            }

        }
    }
}