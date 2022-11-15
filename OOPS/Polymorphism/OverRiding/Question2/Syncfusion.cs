namespace Question2
{
    public class Syncfusion:FreeLancer
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; set; }
        public string WorkLocation { get; set; }
        public Syncfusion(string name,string fatherName,Gender gender,string qualification,string role,int noOfWorkingDays,string workLocation):base(name,fatherName,gender,qualification,role,noOfWorkingDays)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            WorkLocation=workLocation;
        }
        public override void CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
        }
        public override void Display()
        {
            System.Console.WriteLine($"Name         :{Name}");
            System.Console.WriteLine($"FatherName   :{FatherName}");
            System.Console.WriteLine($"Gender       :{Gender}");
            System.Console.WriteLine($"Qualification:{Qualification}");
            System.Console.WriteLine($"EmpID        :{EmployeeID}");
            System.Console.WriteLine($"WorkLocation  :{WorkLocation}" );
        }
    }
}