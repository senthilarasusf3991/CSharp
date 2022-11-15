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
            System.Console.Write("Enter a Char :");
            arr[i]=char.Parse(Console.ReadLine());
        }
        int k,j;
        char temp;
        for(k=1;k<arr.Length;k++)
        {
            temp=arr[k];
            j=k-1;

            while(j>=0 && temp>= arr[j])
            {
                arr[j+1]=arr[j];
                j=j-1;
            }
            arr[j+1]=temp;
        }
        foreach(char item in arr)
        {
            System.Console.WriteLine(item);
        }

    }
}