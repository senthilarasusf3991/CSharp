
using System;
namespace MultiplyInheritence
{
    class Program
    {
        public static void Main(string[] args)
        {
            //PersonalDetails Person= new PersonalDetails("senthi","balu",Gender.Male,new DateTime(2000,10,05));
            //Person.ShowDetails();
            StudentDetails student= new StudentDetails("AID1001","senthil","balu",Gender.Male,new DateTime(2000,10,05),Department.ECE,Year.Firstyear);
            student.ShowStudent();
            student.getMarkDetails(90.0);
            System.Console.WriteLine(student.CGPA);
        }
    }
}