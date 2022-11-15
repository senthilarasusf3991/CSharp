using System;
namespace Question1
{

    public class EmployeeInfo:FamilyInfo
    {
        private static int s_employeeID=1000; 
        public string EmployeeID { get; set; }
        public DateTime DateOfJoining { get; set; }
        
        public EmployeeInfo(string name,string fatherName,long mobile,string mailID,Gender gender,string motherName,int noOfSibilings,string nativePlace,DateTime dateOfJoining):base(name, fatherName, mobile, mailID, gender,motherName,noOfSibilings,nativePlace)
        {
            DateOfJoining=dateOfJoining;;
        }
        public override void Update(string name)
        {
            Name=name;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            System.Console.WriteLine("MotherName      :"+MotherName);
            System.Console.WriteLine("Noof sibilings  :"+NoOfSibilings);
        }
        
    }
}