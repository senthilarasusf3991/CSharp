namespace Question1
{

    public class EmployeeInfo:PersonalInfo
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get{s_employeeID++;return "EID"+s_employeeID;} }
        public EmployeeInfo(string name,string fatherName,long mobile,Gender gender):base(name,fatherName,mobile,gender)
        {
            
        }
        public override void Display()
        {
            ShowPersonalInfo();
            System.Console.WriteLine($"EmployeeID is   :{EmployeeID}");
        }
        
        
    }
}