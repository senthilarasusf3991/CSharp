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
            System.Console.Write("Enter a string :");
            arr[i]=Console.ReadLine();
        }
        System.Console.Write("Enter a string to be searched ");
        string searchString=Console.ReadLine();
        Search(arr,searchString);
    }
    public static void Search(string []arr,string searchString)
    {
        int start=0;
        int end=arr.Length-1;
        int mid;
        while(start<=end)
        {
            mid=(end+start)/2;
            int result=searchString.CompareTo(arr[mid]);
            if(result==0)
            {
                System.Console.WriteLine($"string found at {mid}");
                return;
            }
            else if(result<0)
            {
                end=mid-1;
            }
            else
            {
                start=mid+1;
            }
        }
        System.Console.WriteLine("string not found");
    }
}