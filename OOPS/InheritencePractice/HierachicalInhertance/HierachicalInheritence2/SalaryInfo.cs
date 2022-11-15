namespace HierachicalInheritence2
{
    public class SalaryInfo
    {
        public double BasicSalary{get;set;}
        public string Month{get;set;}
        public SalaryInfo(double basicSalary, string month)
        {
            BasicSalary=basicSalary;
            Month=month;
        }
    }
}