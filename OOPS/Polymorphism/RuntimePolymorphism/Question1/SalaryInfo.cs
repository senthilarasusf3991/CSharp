namespace Question1
{
    
    public class SalaryInfo:EmployeeInfo
    {
        public int NoOfDaysWorked { get; set; }
      
        public SalaryInfo(string name,string fatherName,long mobile,Gender gender,int noOfDaysWorked):base(name,fatherName,mobile,gender)
        {
            NoOfDaysWorked=noOfDaysWorked;
        }
        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("Salary    :"+(500*NoOfDaysWorked));
        }
        
        
    }
}