using System;
namespace CollegeAdmission
{
    public enum Gender{Default, Male, Female, Transgender}
    public class StudentDetails
    {
        private static int s_studentID=3000;
        public string StudentID {get; }
        public string StudentName {get; set;}
        public string FatherName{get;set;}
        public DateTime DOB{get;set;}
        public Gender HolderGender{get; set;}
        public double PhysicsMark{get; set;}
        public double ChemistryMark{get; set;}
        public double MathsMark{get; set;}

        public StudentDetails (string studentName, string fatherName, DateTime dob, Gender holderGender,double physicsMark, double chemistryMark, double mathsMark)
        {
            s_studentID++;
            StudentID ="SF"+s_studentID;
            StudentName=studentName;
            FatherName=fatherName;
            DOB=dob;
            HolderGender=holderGender;
            PhysicsMark=physicsMark;
            ChemistryMark=chemistryMark;
            MathsMark=mathsMark;
        }
        public bool CheckEligibility()
        {
            double total=PhysicsMark+ChemistryMark+MathsMark;
            double average=total/3;
            if(average>75.0)
            {
                return true;

            }
            else
            {
                return false;
            }


        }
        public StudentDetails(string data)
        {
            string[] values=data.Split(",");
            s_studentID=int.Parse(values[0].Remove(0,2));
            StudentID=values[0];
            StudentName=values[1];
            FatherName=values[2];
            DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
            HolderGender=Enum.Parse<Gender>(values[4],true);

            PhysicsMark=int.Parse(values[5]);
            ChemistryMark=int.Parse(values[6]);
            MathsMark=int.Parse(values[7]);
            







        }
        


    }
}