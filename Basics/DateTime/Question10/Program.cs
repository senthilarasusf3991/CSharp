
using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime now=DateTime.Now;
            System.Console.WriteLine($"Yesterday: {now.AddDays(-1).ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Tomorrow: {now.AddDays(1).ToString("dd/MM/yyyy")}");
        }
    }
}