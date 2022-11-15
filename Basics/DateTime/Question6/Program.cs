
using System;
namespace Question6

{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime newDate=new DateTime();
            newDate=DateTime.Today;
            DateTime newDateOne=newDate.AddDays(40);
            System.Console.WriteLine(newDateOne.ToString("dddd"));
        
        }
    }
}