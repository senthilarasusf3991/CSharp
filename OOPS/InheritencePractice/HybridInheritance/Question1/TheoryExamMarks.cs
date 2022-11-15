using System;
namespace Question1
{
    public class TheoryExamMarks:PersonalInfo
    {
        public double Sem1{get;set;}
        public double Sem2{get;set;}
        public double Sem3{get;set;}
        public double Sem4{get;set;}

   
        public TheoryExamMarks(string registrationNumber,string name, string faterName,long phoneNumber, DateTime dOB, Gender gender,double sem1,double sem2,double sem3,double sem4):base( registrationNumber, name,  faterName, phoneNumber,  dOB,  gender)
        {
            Sem1=sem1;
            Sem2=sem2;
            Sem3=sem3;
            Sem4=sem4;
        }
        
        public void ShowTheoryExamMarkDetails()
        {
            ShowPersonalInfo();
            System.Console.WriteLine($"Semester1 mark is {Sem1}");
            System.Console.WriteLine($"Semester2 mark is {Sem2}");
            System.Console.WriteLine($"Semester3 mark is {Sem3}");
            System.Console.WriteLine($"Semester4 mark is {Sem4}");
     
            

        }

        

    }
}