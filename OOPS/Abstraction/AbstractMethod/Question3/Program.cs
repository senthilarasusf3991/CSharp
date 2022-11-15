using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        FullTimeEmployee fullTimeEmployee=new FullTimeEmployee("senthil",Gender.Male,22);
        System.Console.WriteLine("Full time employee");
        fullTimeEmployee.DisplaySalary();

        PartTimeEmployee partTimeEmployee=new PartTimeEmployee("arasu",Gender.Male,23);
        System.Console.WriteLine("Part Time employee");
        partTimeEmployee.DisplaySalary();
    }
}