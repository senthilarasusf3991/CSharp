using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        Student student=new Student("senthil",9629254088,Gender.Male,new DateTime(2000,10,04),88,90,98);
        student.Display();
        Console.WriteLine("Percentage is  "+student.CalculatePercentage());
        System.Console.WriteLine("Total mark  :"+student.TotalMark());
    }
}