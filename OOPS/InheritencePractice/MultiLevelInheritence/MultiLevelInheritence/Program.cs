
using System;
namespace MultiLevelInheritence
{
    class Program
    {
        public static void Main(string[] args)
        {
            //PersonalDetails Person= new PersonalDetails("senthi","balu",Gender.Male,new DateTime(2000,10,05));
            //Person.ShowDetails();
            //StudentDetails student= new StudentDetails("AID1001","senthi","balu",Gender.Male,new DateTime(2000,10,05),Department.ECE,Year.Firstyear);
            //student.ShowStudent();
            EmploymentDetails employee= new EmploymentDetails("SID1001","AID1001","senthi","balu",Gender.Male,new DateTime(2000,10,05),Department.ECE, DateTime.Now);
            employee.ShowEmployee();

        }
    }
}