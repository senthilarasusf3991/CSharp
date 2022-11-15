using System;
namespace Question1
{
    public delegate void Holder();
    public class StudentDetails
    {
        private static int s_studentID = 1000;
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Maths { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }
        public void GetDetails ()
        {
            double physics, chemistry, maths;
            s_studentID++;
            StudentID = "SID" + s_studentID;
            System.Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            System.Console.Write("Enter Father name: ");
            FatherName = Console.ReadLine();
            System.Console.Write("Enter Physics mark: ");
            while (!double.TryParse(Console.ReadLine(), out physics))
            {
                System.Console.Write("Invalid Entry..\n\nEnter Physics mark: ");
            }
            System.Console.Write("Enter Chemistry mark: ");
            while (!double.TryParse(Console.ReadLine(), out chemistry))
            {
                System.Console.Write("Invalid Entry..\n\nEnter Chemistry mark: ");
            }
            System.Console.Write("Enter Maths mark: ");
            while (!double.TryParse(Console.ReadLine(), out maths))
            {
                System.Console.Write("Invalid Entry..\n\nEnter Maths mark: ");
            }
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }
        public void Calculate()
        {
            Total = Physics + Chemistry + Maths;
            Percentage = Total/3;
            System.Console.WriteLine($"Total mark : {Total}");
            System.Console.WriteLine($"Percentage : {Percentage} %");
        }
    }
}