using System;
namespace Question1
{
    public enum Gender{Default,Male,Female,Transgender}
    public partial class Employee
    {
        private static int s_employeeID=100;
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public Gender Gender{ get; set; }
        public DateTime DOB { get; set; }
        public long MobileNumber { get; set; }
        
        
    }
}