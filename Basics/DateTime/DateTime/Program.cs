
using System;
namespace DateTimePrac
{
    class Program
    {
        public static void Main(string[] args)
        {
            DateTime date=new DateTime(2021,8,10,10,40,32);
            System.Console.WriteLine("Year: "+date.Year);
            System.Console.WriteLine("Month: "+date.Month);
            System.Console.WriteLine("Day: "+date.Day);
            System.Console.WriteLine("Hour: "+date.Hour);
            System.Console.WriteLine("Minute: "+date.Minute);
            System.Console.WriteLine("Second: "+date.Second);

            System.Console.WriteLine(date.ToString("yyyy/MM/dd/ hh:mm:ss tt"));
            string datetime=Console.ReadLine();
            string[] splita = datetime.Split('/',':',' ');

            

            for(int i=splita.Length-1;i>=0;i--)
            {
                System.Console.Write(splita[i]+" ");
            }System.Console.WriteLine();

            System.Console.WriteLine("Enter the dob yyyy/MM/dd hh:mm:ss tt  format");
            DateTime dateYearMonth=DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd hh:mm:ss tt",null);
            System.Console.WriteLine("Year: "+dateYearMonth.Year);
            System.Console.WriteLine("Month: "+dateYearMonth.Month);
            System.Console.WriteLine("Day: "+dateYearMonth.Day);
            
            

        }
    }
}