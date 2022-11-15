using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            if(current.CompareTo(current.AddYears(1))==1)
                System.Console.WriteLine($"{current.ToString()} is Later than {current.AddYears(1).ToString()}");
            else
                System.Console.WriteLine($"{current.ToString()} is Earlier than {current.AddYears(1).ToString()}");
            if(current.CompareTo(current.AddYears(-1))==1)
                System.Console.WriteLine($"{current.ToString()} is Later than {current.AddYears(-1).ToString()}");
            else
                System.Console.WriteLine($"{current.ToString()} is Earlier than {current.AddYears(-1).ToString()}");
            
        }
    }
}