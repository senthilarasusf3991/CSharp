using System;
namespace Question3;
class program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        char[] arr=new char[size];
        for (int i=0;i<arr.Length;i++)
        {
            System.Console.WriteLine("Enter the char to be added in array:");
            arr[i]=char.Parse(Console.ReadLine());

        }
        char temp;
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=0;j<arr.Length-i-1;j++)
                {
                    if((arr[j]<arr[j+1]))
                    {
                        temp=arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=temp;
                    }
                }
            }
            foreach(char i in arr)
            {
                System.Console.WriteLine(i);
            }

    }
    
}