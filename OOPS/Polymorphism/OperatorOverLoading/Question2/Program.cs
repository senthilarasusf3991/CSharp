using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Semester sem1=new Semester(90,87,67,58,86,96); Semester sem2=new Semester(80,76,67,87,98,89); Semester sem3=new Semester(90,87,67,58,86,96); Semester sem4=new Semester(93,56,76,89,98,78);
        Semester totalSemesters=sem1+sem2+sem3+sem4;
        System.Console.WriteLine($"Total Marks is :{totalSemesters.TotalMarks}");
        System.Console.WriteLine($"Total Percentage :{totalSemesters.Percentage}");
        
    }
    
}