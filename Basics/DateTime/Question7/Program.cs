
using System;
namespace Question7

{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime newDate=new DateTime();
            System.Console.Write("Enter the date in dd/MM/yyyy HH:mm:ss tt :");
            newDate=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
            DateTime newDateOne=new DateTime();
            System.Console.Write("Enter the date in dd/MM/yyyy HH:mm:ss tt :");
            newDateOne=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy hh:mm:ss tt",null);
            int result = DateTime.Compare(newDateOne,newDate);
            if (result>0)
            {
                System.Console.WriteLine($"{result}:{newDate} is earlier than {newDateOne}");
            }
            else{
                System.Console.WriteLine($"{result}:{newDate} is later than {newDateOne}");
            }
        
        }
    }
}

