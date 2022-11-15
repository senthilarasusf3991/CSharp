using System;
namespace Question5;
public delegate bool Filt(int number1, int number2);
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        int[] arr=new int[size];
        for (int i=0;i<arr.Length;i++)
        {
            System.Console.WriteLine("Enter the numbers to be added in array:");
            arr[i]=int.Parse(Console.ReadLine());

        }
        bool IsAscending(int a , int b)
        {
            if(a>b)
            {
                return true;
            }
            return false;
        }
        bool IsDescending(int a , int b)
        {
            if(a<b)
            {
                return true;
            }
            return false;
        }
        int[] Sort(int [] arr,Filt filter)
        {
            int temp;
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=0;j<arr.Length-i-1;j++)
                {
                    if(filter(arr[j],arr[j+1]))
                    {
                        temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                    }
                }
            }
            return arr;
        }
        
        arr=Sort(arr,IsAscending);
        System.Console.WriteLine("Ascending Numbers");
        foreach(int i in arr)
        
        {
            
            System.Console.WriteLine(i);
        }

        arr=Sort(arr,IsDescending);
        System.Console.WriteLine("Descending numbers");
        foreach(int i in arr)
        
        {
            
            System.Console.WriteLine(i);
        }
        
    }
}