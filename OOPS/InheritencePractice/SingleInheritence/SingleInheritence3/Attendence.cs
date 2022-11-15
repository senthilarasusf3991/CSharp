using System;
namespace SingleInheritence3

{


    public class Attendance
    {
        public DateTime Date { get; set; }
        public int NoOfHoursWorked { get; set; }
        
        public Attendance(DateTime date,int noOfHoursWorked)
        {
            Date=date;
            NoOfHoursWorked=noOfHoursWorked;
        }
        
        
    }
}