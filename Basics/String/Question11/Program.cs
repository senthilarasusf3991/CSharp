
using System;
using System.Linq;
using System.Collections.Generic;
namespace Question11
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter string:");
            string str = Console.ReadLine();
            var ch = new HashSet<char>(str);
            foreach(char item in ch)
            System.Console.Write(item);
        }
    }
}