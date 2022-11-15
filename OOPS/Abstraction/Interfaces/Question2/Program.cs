using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("senthil","balu","9629254088");
        EmployeeInfo employee=new EmployeeInfo("arasu","aari");
        student.Display();
        employee.Display();
    }
}