using System;


namespace SingleInheritence1
{
    public enum Standard{Default , FirstYear, Secondyear, ThirdYear};
    public enum Branch{Default, Pharma, Food, Biotech}
    public class StudentInfo:PersonalInfo
    {
        private static int s_registerNumber=200;
        public string RegistrationNumber{get;}
        public Standard StandardClass{get;set;}
        public Branch DeptBranch{get;set;}
        public DateTime AcadamicYear {get;set;}
   
        public StudentInfo(string name,string fatherName,long phoneNumber, string mailID, DateTime dob,Gender holderGender,Standard standardClass, Branch deptBranch, DateTime acadamicYear):base(name,fatherName,phoneNumber,mailID,dob,holderGender)

        {
            s_registerNumber++;
            RegistrationNumber="SID"+s_registerNumber;
            StandardClass=standardClass;
            DeptBranch=deptBranch;
            AcadamicYear=acadamicYear;
        }
        public void UpdateInfo(string name,string fatherName,long phoneNumber, string mailID, DateTime dob,Gender holderGender,Standard standardClass, Branch deptBranch, DateTime acadamicYear)
        {
            StandardClass=standardClass;
            DeptBranch=deptBranch;
            AcadamicYear=acadamicYear;
            Name=name;
            FatherName=fatherName;
            MailID=mailID;
            PhoneNumber=phoneNumber;
            DOB=dob;
            HolderGender=holderGender;
        }
        public void StudentInformation()
        {
            System.Console.WriteLine("STUDENT DETAILS");
            System.Console.WriteLine($"RegisterationNumber   :{RegistrationNumber}");
            System.Console.WriteLine($"Name                  :{Name}");
            System.Console.WriteLine($"FatherName            :{FatherName}");
            System.Console.WriteLine($"DateOfBirth           :{DOB.ToShortDateString()}");
            System.Console.WriteLine($"Gender                :{HolderGender}");
            System.Console.WriteLine($"Standard              :{StandardClass}");
            System.Console.WriteLine($"Branch                :{DeptBranch}");
            System.Console.WriteLine($"AcadamicYear          :{AcadamicYear.ToString("yyyy")}");
            System.Console.WriteLine($"MailID                :{MailID}");
            System.Console.WriteLine($"PhoneNumber           :{PhoneNumber}");
        }
            
        
    }
}