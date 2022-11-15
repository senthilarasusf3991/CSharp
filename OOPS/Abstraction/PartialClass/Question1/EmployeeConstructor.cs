using System;
namespace Question1
{

    public partial class Employee
    {
        public Employee(string name,Gender gender,DateTime dob,long mobile)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Name=name;
            Gender=gender;
            DOB=dob;
            MobileNumber=mobile;
        }
    }
}