using System;
namespace Question4;
class Program{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter the size of an array ");
        int size=int.Parse(Console.ReadLine());
        string []arr=new string[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.Write("Enter a string :");
            arr[i]=(Console.ReadLine());
        }
        int j,small;
        for(int i=0;i<arr.Length-1;i++)
        {
            small=i;
            for(j=i+1;j<arr.Length;j++)
            {
                if(arr[j].CompareTo(arr[small])<=0)
                {
                    small=j;
                }
            }
            string temp=arr[small];
            arr[small]=arr[i];
            arr[i]=temp;
            
            
        }
        foreach(string val in arr)
        {
            System.Console.WriteLine(val);
        }
    }
}