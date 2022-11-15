using System;
using System.Collections.Generic;
namespace HierachicalInheritence2;
class Program{
    public static void Main(string[] args)
    {
        List<TemporaryEmployee> temporaryEmployeeList=new List<TemporaryEmployee>();
        List<PermanentEmployee> permanentEmployeeList=new List<PermanentEmployee>();
        TemporaryEmployee temporaryEmployee1=new TemporaryEmployee(10000,"March","Temporary");
        TemporaryEmployee temporaryEmployee2=new TemporaryEmployee(12000,"March","Temporary");
        temporaryEmployeeList.Add(temporaryEmployee1);
        temporaryEmployeeList.Add(temporaryEmployee2);
       
        
        PermanentEmployee permanentEmployee1=new PermanentEmployee(20000,"April","Permanent");
        PermanentEmployee permanentEmployee2=new PermanentEmployee(25000,"April","Permanent");
        permanentEmployeeList.Add(permanentEmployee1);
        permanentEmployeeList.Add(permanentEmployee2);

        foreach(TemporaryEmployee temporaryEmp in temporaryEmployeeList)
        {
            if (temporaryEmp.EmployeeID.Equals("TEID101"))
            {
                System.Console.WriteLine("------Temporary Employee------");
                temporaryEmp.TotalSalaryCalculation();
                temporaryEmp.ShowSalary();
            }
        }
        foreach(PermanentEmployee permanentEmp in permanentEmployeeList)
        {
            if(permanentEmp.EmployeeID.Equals("EID102"))
            {
                System.Console.WriteLine("------Permanent Employee--------");
                permanentEmp.TotalSalaryCalculation();
                permanentEmp.ShowSalary();
            }
        }
    }
}