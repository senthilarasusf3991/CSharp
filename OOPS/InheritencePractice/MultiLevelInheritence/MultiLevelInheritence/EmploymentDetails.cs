using System;
namespace MultiLevelInheritence
{
    public class EmploymentDetails:StudentDetails
    {
        private static int s_employeeID=1000;
        public string EmployeeID{get;}
        public DateTime DateOfJoining{get;set;}
        public EmploymentDetails(string StudentID,string aID,string name, string fatherName, Gender holderGender, DateTime dob,Department studentDepartment,DateTime dateOfJoining): base( StudentID, aID, name,  fatherName,  holderGender,  dob, studentDepartment)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            DateOfJoining=dateOfJoining;
        }
        public void ShowEmployee()
        {
            System.Console.WriteLine($"EmployeeID :{EmployeeID}");
            System.Console.WriteLine($"DateOfJoining : {DateOfJoining}");
            ShowDetails();
        }

    }
}