using System;
namespace Question2;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        float[] arr=new float[size];
        for (int i=0;i<arr.Length;i++)
        {
            System.Console.WriteLine("Enter the numbers to be added in array:");
            arr[i]=float.Parse(Console.ReadLine());

        }
        float temp;
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
            foreach(float i in arr)
            {
                System.Console.WriteLine(i);
            }

    }
    
}