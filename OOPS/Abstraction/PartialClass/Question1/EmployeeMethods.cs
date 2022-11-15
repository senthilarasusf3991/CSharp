using System;
namespace Question1
{
    public partial class Employee
    {
        public void Update(string name,Gender gender,DateTime dob,long mobile)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            MobileNumber=mobile;
        }
        public void Display()
        {
            System.Console.WriteLine($"Name is           :{Name}");
            System.Console.WriteLine($"EmployeeID is     :{EmployeeID}");
            System.Console.WriteLine($"Gender is         :{Gender}");
            System.Console.WriteLine($"DOB   is          :{DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"MobileNumber is   :{MobileNumber}");
        }
    }
}