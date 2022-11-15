namespace HierachicalInheritence2
{
    public class PermanentEmployee:SalaryInfo
    {
        private static int s_employeeID=100;
        public string EmployeeID{get;set;}
        public string EmployeeType{get;set;}
        public double DA=0.2;
        public double HRA=0.18;
        public double PF=0.1;
        public double TotalSalary{get;set;}
        public PermanentEmployee(double basicSalary, string month,string employeeType):base( basicSalary,  month)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            EmployeeType=employeeType;
            
        }
        public void TotalSalaryCalculation()
        {
            TotalSalary=BasicSalary+(DA+HRA+PF)*BasicSalary;

        }
        public void ShowSalary()
        {
            System.Console.WriteLine($"Your salary is {TotalSalary}");
        }
    }
}