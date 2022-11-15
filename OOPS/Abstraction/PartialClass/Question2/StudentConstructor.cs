using System;
namespace Question2
{
    public partial class Student
    {
        public Student(string name,long mobile,Gender gender,DateTime dob,int physicsMark,int chemistryMark,int mathsMark)
        {
            Name=name;
            Mobile=mobile;
            Gender=gender;
            DOB=dob;
            PhysicsMark=physicsMark;
            ChemistryMark=chemistryMark;
            MathsMark=mathsMark;
        }
    }
}