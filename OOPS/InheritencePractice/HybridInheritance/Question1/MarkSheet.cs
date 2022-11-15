using System;
namespace Question1
{
    public class MarkSheet:TheoryExamMarks,ICalculate
    {
        public int MarkSheetNumber{get;set;}
        public DateTime DateOfIssue{get;set;}
        public double Total{get;set;}
        public double Percentage{get;set;}
        public int ProjectMark{get;set;}
        public MarkSheet(string registrationNumber,string name, string faterName,long phoneNumber, DateTime dOB, Gender gender,double sem1,double sem2,double sem3,double sem4,int markSheetNumber, DateTime dateOfIssue):base( registrationNumber, name,  faterName, phoneNumber,  dOB,  gender,sem1,sem2,sem3,sem4)
        {
            MarkSheetNumber=markSheetNumber;
            DateOfIssue = dateOfIssue;

            
        }
        public void CalulateUG()
        {
            Total=Sem1+Sem2+Sem3+Sem4;
            Percentage=(Total/4);
            System.Console.WriteLine($"CGPA of the student is {Percentage}");
        }
        public void MarkSheetDetails()
        {
            ShowTheoryExamMarkDetails();
            System.Console.WriteLine($"MarkSheet Number is  :{MarkSheetNumber}");
            System.Console.WriteLine($"Date Of Issue is     :{DateOfIssue.ToString("dd/MM/yyyy")}");
            
            
        }


    }
}