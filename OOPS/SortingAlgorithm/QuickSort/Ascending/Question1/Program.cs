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
        Quick(arr,0,arr.Length-1);
        foreach(int item in arr)
        {
            System.Console.WriteLine(item);
        }
    }
    static int Partition (int[] arr, int start , int end)
    {
        int pivot=arr[end];
        int i=(start-1);
        int temp;
        for(int j=start;j<=end-1;j++)
        {
            if(arr[j]<pivot)
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
    static void Quick (int []arr, int start , int end)
    {
        if(start < end)
        {
            int position=Partition(arr,start,end);
            Quick (arr,start,position-1);
            Quick(arr, position+1,end);
        }
    }
    
}