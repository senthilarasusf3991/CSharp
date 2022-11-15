using System;
namespace Question4;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        string[] arr=new string[size];
        for (int i=0;i<arr.Length;i++)
        {
            System.Console.WriteLine("Enter the string to be added in array:");
            arr[i]=(Console.ReadLine());

        }
        string temp;
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=0;j<arr.Length-i-1;j++)
                {
                    if((arr[j].CompareTo(arr[j+1])>=0))
                    {
                        temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                    }
                }
            }
            foreach(string i in arr)
            {
                System.Console.WriteLine(i);
            }

    }
    
}