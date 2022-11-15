using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Please note - THIS IS A BAD APPLICATION - DO NOT REPLICATE WHAT IT DOES
// This application was designed to simulate a poorly-built application that
// you need to support. Do not follow any of these practices. This is for 
// demonstration purposes only. You have been warned.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName="";
            int i=0;
            double hoursWorked=0;
            double totalHours=0;

            List<TimeSheetEntry> entryList = new List<TimeSheetEntry>();
            Console.Write("Enter where did you worked?");
            companyName = Console.ReadLine();
            Console.Write("Enter how many hours have you worked? ");
            hoursWorked = double.Parse(Console.ReadLine());
            TimeSheetEntry entry = new TimeSheetEntry();
            entry.HoursWorked = hoursWorked;
            entry.WorkDone = companyName;
            entryList.Add(entry);
            Console.Write("Do you want to enter more time:");
            string choice =(Console.ReadLine().ToLower());
            while (choice == "yes")
            {
                Console.Write("Enter where did you worked?");
                companyName = Console.ReadLine();
                Console.Write("Enter how many hours have you worked? ");
                hoursWorked = double.Parse(Console.ReadLine());
                TimeSheetEntry newEntry = new TimeSheetEntry();
                entry.HoursWorked = hoursWorked;
                entry.WorkDone = companyName;
                entryList.Add(entry);
                Console.Write("Do you want to enter more time:");
                choice =(Console.ReadLine().ToLower());
            } 
            totalHours = 0;
            for (i = 0; i < entryList.Count; i++)
            {
                if (entryList[i].WorkDone.ToLower().Contains("acme"))
                {
                    totalHours += entryList[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to Acme");
            Console.WriteLine("Your bill is $" + totalHours * 150 + " for the hours worked.");
            totalHours = 0;
            for (i = 0; i < entryList.Count; i++)
            {
                if (entryList[i].WorkDone.ToLower().Contains("abc"))
                {
                    totalHours += entryList[i].HoursWorked;
                }
            }
            Console.WriteLine("Simulating Sending email to ABC");
            Console.WriteLine("Your bill is $" + totalHours * 125 + " for the hours worked.");
            totalHours = 0;
            for (i = 0; i < entryList.Count; i++)
            {
                totalHours += entryList[i].HoursWorked;
            }
            if (totalHours > 40)
            {
                Console.WriteLine("You will get paid $" + ((40*10)+((totalHours-40)*15)) + " for your work.");
            }
            else
            {
                Console.WriteLine("You will get paid $" + (totalHours) * 10 + " for your time.");
            }
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
    }

    public class TimeSheetEntry
    {
        public string WorkDone;
        public double HoursWorked;
    }
}
