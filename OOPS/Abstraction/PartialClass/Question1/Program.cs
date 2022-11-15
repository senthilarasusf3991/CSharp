using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Employee employee=new Employee("Senthilarasu",Gender.Male,new DateTime(2000,10,16),9629254088);
        System.Console.WriteLine("Before Update Info");
        employee.Display();
        employee.Update("senthilbalu",Gender.Male,new DateTime(2002,10,12),9842393338);
        System.Console.WriteLine(" After Update Info ");
        employee.Display();
    }
}