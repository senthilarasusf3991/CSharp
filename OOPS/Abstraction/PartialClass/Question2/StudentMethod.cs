namespace Question2
{
    public partial class Student
    {
        public int TotalMark()
        {
            return (PhysicsMark+ChemistryMark+MathsMark);
        }
        public int CalculatePercentage()
        {
            return (PhysicsMark+ChemistryMark+MathsMark)/3;
        }
        public void Display()
        {
            System.Console.WriteLine($"StudentID is   :{StudentID}");
            System.Console.WriteLine($"Name is         :{Name}");
            System.Console.WriteLine($"Mobile is       :{Mobile}");
            System.Console.WriteLine($"Gender   is     :{Gender}");
            System.Console.WriteLine($"DOB  is         :{DOB}");
            System.Console.WriteLine($"PhysicsMark is  :{PhysicsMark}");
            System.Console.WriteLine($"ChemistryMark is :{ChemistryMark}");
            System.Console.WriteLine($"MathsMark is     :{MathsMark}");
        }
    }
}