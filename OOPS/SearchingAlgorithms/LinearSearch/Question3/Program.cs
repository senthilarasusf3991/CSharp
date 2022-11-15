using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the size of the array: ");
        int size=int.Parse(Console.ReadLine());
        char []arr=new char[size];
        for(int i=0;i<arr.Length;i++)
        {
            System.Console.WriteLine("Enter a Character: ");
            arr[i]=Console.ReadLine()[0];
        }
        System.Console.WriteLine("Enter a character to be searched: ");
        char searchChar=Console.ReadLine()[0];
        Search(arr,searchChar);

        
    }
    public static void Search(char []arr, char searchChar)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i].Equals(searchChar))
            {
                System.Console.WriteLine($"Character found at postion {i}");
                return;
            }
        }
        System.Console.WriteLine("Character not found");
    }
}