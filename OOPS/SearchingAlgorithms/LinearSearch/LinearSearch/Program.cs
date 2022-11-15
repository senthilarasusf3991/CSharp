using System;
namespace SearchingAlgorithm;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the array size: ");
        int size=int.Parse(Console.ReadLine());
        int []arr=new int[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter the number :");
            arr[i]=int.Parse(Console.ReadLine());
        }
        System.Console.Write("Enter the number to be searched ");
        int searchNumber=int.Parse(Console.ReadLine());
        Search(arr,searchNumber);
    }
    public static void Search(int []arr,int searchNumber)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==searchNumber)
            {
                System.Console.WriteLine($"Number found at index position {i}");
                return ;
            }
        }
        System.Console.WriteLine("Number not found");
    }
}