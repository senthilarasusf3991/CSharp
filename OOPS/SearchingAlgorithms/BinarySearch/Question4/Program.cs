using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=int.Parse(Console.ReadLine());
        float []arr=new float[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a number :");
            arr[i]=float.Parse(Console.ReadLine());
        }
        System.Console.Write("Enter a number to be searched ");
        float searchFloat=float.Parse(Console.ReadLine());
        BinarySearching(arr,searchFloat);
    }
    public static void BinarySearching(float []arr,float searchFloat)
    {
        int start=0;
        int end=arr.Length-1;
        int mid;
        while(start<=end)
        {
            mid=(end+start)/2;
            if(arr[mid]==searchFloat)
            {
                System.Console.WriteLine($"Element found at {mid}");
                return;
            }
            else if(arr[mid]>searchFloat)
            {
                end=mid-1;
            }
            else
            {
                start=mid+1;
            }
        }
        System.Console.WriteLine("Not found");
    }
}