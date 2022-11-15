using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=int.Parse(Console.ReadLine());
        string []arr=new string[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter the ID :");
            arr[i]=Console.ReadLine();
        }
        System.Console.Write("Enter a ID to be searched ");
        string searchString=Console.ReadLine();
        Search(arr,searchString);
    }
    public static void Search(string []arr,string searchString)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i].Equals(searchString))
            {
                System.Console.WriteLine($"String found at position {i}");
                return ;
            }
        }
        System.Console.WriteLine("String not found");
    }
}