using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of array: ");
        int size=int.Parse(Console.ReadLine());
        float []arr=new float[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.WriteLine("Enter a number:  ");
            arr[i]=float.Parse(Console.ReadLine());
        }
        System.Console.WriteLine("Enter the float number to be searched: ");
        float searchFloat=float.Parse(Console.ReadLine());
        Search(arr,searchFloat);
    }
    public static void Search(float []arr,float searchFloat)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i].Equals(searchFloat))
            {
                System.Console.WriteLine($"Number found at position {i}");
                return;
            }
        }
        System.Console.WriteLine("Number not found");
    }
}