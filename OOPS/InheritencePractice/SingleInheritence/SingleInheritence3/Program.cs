using System;
namespace SingleInheritence3;
class Program{
    public static void Main(string[] args)
    {
        SalaryInfo salary=new SalaryInfo(10000,"October",DateTime.Today,8);
        salary.DisplaySalary();
    }
}