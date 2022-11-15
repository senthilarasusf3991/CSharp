using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo("senthil","balu",9629254088,"senthil@mail",Gender.Male,"jeyalakshmi",3,"madurai",DateTime.Now);
        employee.Update();
    }
}