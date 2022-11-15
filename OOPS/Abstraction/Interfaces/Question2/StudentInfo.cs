using System;
namespace Question2
{
    public class StudentInfo:DisplayInfo
    {
        private static int s_studentID=1000;
        public string StudentID{get;set;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MobileNumber { get; set; }
        
        public StudentInfo(string name,string FatherName,string mobile)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Name=name;
            this.FatherName=FatherName;
            MobileNumber=mobile;
        }
        public void Display()
        {
            System.Console.WriteLine($"StudentID      :{StudentID}");
            System.Console.WriteLine($"Name           :{Name}");
            System.Console.WriteLine($"FatherName     :{FatherName}");
            System.Console.WriteLine($"Mobile         :{MobileNumber}");
        }
        
    }
}