using System;
namespace Question1;
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
        Quick(arr,0,arr.Length-1);
        foreach(string item in arr)
        {
            System.Console.WriteLine(item);
        }
    }
    static int Partition (string[] arr, int start , int end)
    {
        string pivot=arr[end];
        int i=(start-1);
        string temp;
        for(int j=start;j<=end-1;j++)
        {
            if(arr[j].CompareTo(pivot)<=0)
            {
                i++;
                temp=arr[i];
                arr[i]=arr[j];
                arr[j]=temp;
            }
        }
        temp=arr[i+1];
        arr[i+1]=arr[end];
        arr[end]=temp;
        return (i+1);
    }
    static void Quick (string []arr, int start , int end)
    {
        if(start < end)
        {
            int position=Partition(arr,start,end);
            Quick (arr,start,position-1);
            Quick(arr, position+1,end);
        }
    }
    
}