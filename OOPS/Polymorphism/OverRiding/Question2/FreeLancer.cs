namespace Question2
{
    public class FreeLancer:PersonalDetails
    {
        public string Role { get; set; }
        public int SalaryAmount { get; set; }
        public int NoOfWorkingDays { get; set; }
        public FreeLancer(string name,string fatherName,Gender gender,string qualification,string role,int noOfWorkingDays):base(name,fatherName,gender,qualification)
        {
            Role=role;
            
            NoOfWorkingDays=noOfWorkingDays;
        }
        public virtual void CalculateSalary()
        {
            SalaryAmount=NoOfWorkingDays*500;
        }
        public virtual void Display()
        {
            System.Console.WriteLine($"Name         :{Name}");
            System.Console.WriteLine($"FatherName   :{FatherName}");
            System.Console.WriteLine($"Gender       :{Gender}");
            System.Console.WriteLine($"Qualification:{Qualification}");
            System.Console.WriteLine($"Role         :{Role}");
            System.Console.WriteLine($"SalaryAmount :{SalaryAmount}");
        }
    }
}