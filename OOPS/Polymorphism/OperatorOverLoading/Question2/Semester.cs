namespace Question2
{

    public class Semester
    {
        public double TamilMark { get; set; }
        public double EnglishMark { get; set; }
        public double PhysicsMark { get; set; }
        public double ChemistryMark{get;set;}
        public double MathsMark { get; set; }
        public double BiologyMark { get; set; }
        public double TotalMarks { get; set; }
        public double Percentage { get; set; }
        public Semester(double tamil,double english,double physics,double chemsitry,double maths,double biology)
        
        {
            TamilMark=tamil;
            EnglishMark=english;
            PhysicsMark=physics;
            ChemistryMark=chemsitry;
            MathsMark=maths;
            BiologyMark=biology;
        }
        public Semester(){}
        public void CalculateTotal()
        {
            TotalMarks=TamilMark+EnglishMark+MathsMark+PhysicsMark+ChemistryMark+BiologyMark;
        }
        public void CalculatePercentage()
        {
            Percentage=TotalMarks/6;
        }

        public static Semester operator +(Semester sem1,Semester sem2)
    {
        Semester tempSemester=new Semester();
        sem1.CalculateTotal();
        sem2.CalculateTotal();
        sem1.CalculatePercentage();
        sem1.CalculatePercentage();
        //TotalMarks
        tempSemester.TotalMarks=(sem1.TotalMarks+sem2.TotalMarks);
        //TotalPercentage
        tempSemester.Percentage=(sem2.Percentage+sem1.Percentage)/2;
        //BiologyMark
        tempSemester.BiologyMark=(sem1.BiologyMark+sem2.BiologyMark);
        //TamilMark
        tempSemester.TamilMark=sem1.TamilMark+sem2.TamilMark;
        //EnglishMark
        tempSemester.EnglishMark=sem1.EnglishMark+sem2.EnglishMark;
        //PhysicsMark
        tempSemester.PhysicsMark=sem1.PhysicsMark+sem2.PhysicsMark;
        //ChemistryMark
        tempSemester.ChemistryMark=sem1.ChemistryMark+sem2.ChemistryMark;
        //MathsMark
        tempSemester.MathsMark=sem1.MathsMark+sem2.MathsMark;
        return tempSemester;
    }
    }
}