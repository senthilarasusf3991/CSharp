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
        int k,j;
        string temp;
        for(k=1;k<arr.Length;k++)
        {
            temp=arr[k];
            j=k-1;

            while(j>=0 && temp.CompareTo(arr[j])<=0)
            {
                arr[j+1]=arr[j];
                j=j-1;
            }
            arr[j+1]=temp;
        }
        foreach(string item in arr)
        {
            System.Console.WriteLine(item);
        }

    }
}