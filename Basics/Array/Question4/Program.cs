
using System;
namespace Question4
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
            //max and min
            int max=arr[0];
            int min=arr[0];
            for (int i=1;i<arr.Length;i++)
            {
                if (max<arr[i])
                {
                    max=arr[i];
                }
                else if(min>arr[i])
                {
                    min=arr[i];
                }
                
            }
            Console.WriteLine($"The maximum element is {max}");
            Console.WriteLine($"The minimum element is {min}");
                


        }
    }
}