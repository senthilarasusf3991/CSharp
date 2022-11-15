using System;
namespace Question1;
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
        int temp;
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=0;j<arr.Length-i-1;j++)
                {
                    if((arr[j]>arr[j+1]))
                    {
                        temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                    }
                }
            }
            foreach(int i in arr)
            {
                System.Console.WriteLine(i);
            }

    }
    
}