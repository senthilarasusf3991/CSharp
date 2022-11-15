using System;
namespace Question2
{
    public enum Gender{Default,Male,Female,Transgender}
    public partial class Student
    {
        private static int s_studentID=1000;
        public string StudentID{get{s_studentID++;return "SID"+s_studentID;}}
        public string Name { get; set; }
        public long Mobile{get;set;}
        public Gender Gender{get;set;}
        public DateTime DOB { get; set; }
        public int  PhysicsMark { get; set; }
        public int ChemistryMark { get; set; }
        public int  MathsMark { get; set; }       
    }
}