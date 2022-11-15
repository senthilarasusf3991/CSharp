namespace HierachicalInheritence2
{
    public class TemporaryEmployee:SalaryInfo

    {
        private static int s_employeeID=100;
        public string EmployeeID{get;set;}
        public string EmployeeType{get;set;}
        public double DA=0.15;
        public double HRA=0.13;
        public double TotalSalary{get;set;}
        public TemporaryEmployee(double basicSalary, string month,string employeeType):base( basicSalary,  month)
        {
            s_employeeID++;
            EmployeeID="TEID"+s_employeeID;
            EmployeeType=employeeType;
        }
        public void TotalSalaryCalculation()
        {
            TotalSalary=BasicSalary+(DA*HRA)*BasicSalary;
        }
        public void ShowSalary()
        {
            System.Console.WriteLine($"your salary is {TotalSalary}");
        }
    }
}