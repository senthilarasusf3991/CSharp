using System;
namespace EmployeePayroll

{
    public enum gender {Default,Male, Female}
    public class EmployeePayrollManagement
    {
        private int s_employeeID=1000;
        public string Name {get; set;}
        public string Role {get; set;}
        public string WorkLocation {get;set;}
        public string TeamName {get;set;}
        public DateOnly DateOfJoining {get; set;}
        public int NumberOfWorkingDays {get; set;}
        public int NumberOfLeavesTaken {get; set; }
        public gender Gender {get; set;}
        public string EmployeeID {get;}


        public EmployeePayrollManagement(string name, string role, string workLocation , string teamName, DateOnly dateOfJoining , int numberOfWorkingDays , int numberOfLeavesTaken , gender holderGender)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            Name=name;
            Role=role;
            WorkLocation=workLocation;
            TeamName=teamName;
            DateOfJoining=dateOfJoining;
            NumberOfWorkingDays=numberOfWorkingDays;
            NumberOfLeavesTaken=numberOfLeavesTaken;
            Gender=holderGender;

        }

        public double SalaryCalculation(int amountPerDay)
        {
            double salary=NumberOfWorkingDays-NumberOfLeavesTaken;
            return salary*amountPerDay;
        }

    }
}