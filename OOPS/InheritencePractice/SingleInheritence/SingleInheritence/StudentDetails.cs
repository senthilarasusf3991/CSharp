using System;
namespace SingleInheritence
{
    public enum Department{Default, ECE, EEE}

    public enum Year{Default, Firstyear, SecondYear, Thirdyear}
    public class StudentDetails:PersonalDetails
    {
        private static int s_studentID=1000;
        public string StudentID{get;set;}
        public  Department StudentDepartment{get; set;}
        public Year Years{get;set;}
        public StudentDetails(string aID,string name, string fatherName, Gender holderGender, DateTime dob,Department studentDepartment,Year years):base( aID,name,  fatherName,  holderGender,  dob)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            StudentDepartment=studentDepartment;
            Years=years;
        }
        public void ShowStudent()
        {
            System.Console.WriteLine($"StudentID {StudentID}");
            ShowDetails();
            System.Console.WriteLine($"Department  :{StudentDepartment}");
            System.Console.WriteLine($"Year: {Years}");
        }


       

    }
}