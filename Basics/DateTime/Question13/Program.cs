
using System;
namespace Question13
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a date: ");
            int day=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter a month: ");
            int month=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter a year: ");
            int year=int.Parse(Console.ReadLine());

            DateTime date=new DateTime(year,month,day);
            DateTime newDate=date;
            DayOfWeek dayName=date.DayOfWeek;
            switch(dayName.ToString())
            {
                case "Sunday":
                {
                    newDate=date.AddDays(6);
                    break;
                }
                case "Monday":
                {
                    newDate=date.AddDays(5);
                    break;
                }
                case "Tuesday":
                {
                    newDate=date.AddDays(4);
                    break;
                }
                case "Wednesday":
                {
                    newDate=date.AddDays(3);
                    break;
                }
                
                case "Thursday":
                {
                    newDate=date.AddDays(2);
                    break;
                }
                case "Friday":
                {
                    newDate=date.AddDays(1);
                    break;
                }
            }
            System.Console.WriteLine($"Last day of week for the above date is {newDate.ToString("dd/MM/yyyy")}");
           
            

        }
    }
}