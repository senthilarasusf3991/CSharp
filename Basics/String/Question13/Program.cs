using System;

namespace Question13;

class Program{
    public static void Main(string[] args)
    {
        int num,sum=0;
        System.Console.WriteLine("Enter the string: ");
        string str = Console.ReadLine();
        
        foreach(char ch in str)
        {
            if (int.TryParse(""+ch, out num))
            {
                sum+=num;
            }
        }
        System.Console.WriteLine("Sum = "+sum);
    }
}