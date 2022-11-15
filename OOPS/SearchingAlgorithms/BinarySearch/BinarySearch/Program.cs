using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=int.Parse(Console.ReadLine());
        int []arr=new int[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a number :");
            arr[i]=int.Parse(Console.ReadLine());
        }
        System.Console.Write("Enter a number to be searched ");
        int searchNumber=int.Parse(Console.ReadLine());
        Search(arr,searchNumber);
    }
    public static void Search(int []arr,int searchNumber)
    {
        int start=0;
        int end=arr.Length-1;
        int mid;
        while(start<=end)
        {
            mid=(end+start)/2;
            if(arr[mid]==searchNumber)
            {
                System.Console.WriteLine($"Number found at position {mid}");
                return;
            }
            else if(arr[mid]>searchNumber)
            {
                end=mid-1;
            }
            else
            {
                start=mid+1;
            }
        }
        System.Console.WriteLine("Number Not found");
    }
}