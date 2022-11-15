using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=int.Parse(Console.ReadLine());
        char []arr=new char[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a character :");
            arr[i]=Console.ReadLine()[0];
        }
        System.Console.Write("Enter a character to be searched ");
        char searchChar=Console.ReadLine()[0];
        Search(arr,searchChar);
    }
    public static void Search(char []arr,char searchChar)
    {
        int start=0;
        int end=arr.Length-1;
        int mid;
        while(start<=end)
        {
            mid=(end+start)/2;
            int result=searchChar.CompareTo(arr[mid]);
            if(result==0)
            {
                System.Console.WriteLine($"Character found at {mid}");
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
        System.Console.WriteLine("Character not found");
    }
}