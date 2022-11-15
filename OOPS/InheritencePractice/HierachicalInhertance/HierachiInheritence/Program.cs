
using System;
namespace HierachiInheritence
{
    class Program
    {
        public static void Main(string[] args)
        {
            PersonalDetails Person= new PersonalDetails("senthi","balu",Gender.Male,new DateTime(2000,10,05));
            Person.ShowDetails();
            StudentDetails student= new StudentDetails("AID1001","senthi","balu",Gender.Male,new DateTime(2000,10,05),Department.ECE,Year.Firstyear);
            student.ShowStudent();
            AccountDetails account=new AccountDetails("AID1001","senthi","balu",Gender.Male,new DateTime(2000,10,05),Department.ECE,Year.Firstyear,"SB");
            account.StudentAccountInfo();
        }
    }
}