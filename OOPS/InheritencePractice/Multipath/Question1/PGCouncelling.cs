using System;
namespace Question1
{ 
    public enum FeeStatus{Paid,Pending};
    public class PGCancelling:HSCInfo,UGInfo
    {
        private static int s_applicationID=1000;
        public string ApplicationID { get; set; }
        public DateTime DateOfApplication{get;set;}
        public FeeStatus FeeStatus{get;set;}
        public string HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double PercentageMarks { get; set; }
        public string UGMarkSheetNumber { get; set; }
        public double SemesterOne { get; set; }
        public double SemesterTwo { get; set; }
        public double SemesterThree { get; set; }
        public double SemesterFour { get; set; }
        public double TotalMarks { get; set; }
        public double Percentage { get; set; }
        public string AdharNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public PGCancelling(string name,string fatherName,long phone,DateTime dob,Gender gender,string adharNumber,String uGMarkSheetNumber,int physics,int chemistry,int maths,string hSCMarksheetNumber,double sem1,double sem2,double sem3,double sem4,DateTime dateOfApplication)
        {
            s_applicationID++;
            ApplicationID="AID"+s_applicationID;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            AdharNumber=adharNumber;
            Gender=gender;
            UGMarkSheetNumber=uGMarkSheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            HSCMarksheetNumber=hSCMarksheetNumber;
            SemesterOne=sem1;
            SemesterTwo=sem2;
            SemesterThree=sem3;
            SemesterFour=sem4;
            DateOfApplication=dateOfApplication;
        }
        public void ShowHSCMarksheet()
        {
            System.Console.WriteLine($"Physics     :{Physics}");
            System.Console.WriteLine($"Chemistry   :{Chemistry}");
            System.Console.WriteLine($"Maths       :{Maths}");
            System.Console.WriteLine($"Total       :{Total}");
            System.Console.WriteLine($"Percentage  :{PercentageMarks}");
        }
        public void CalculateHSC()
        {
            Total=Physics+Maths+Chemistry;
            PercentageMarks=Total/3;
        }
        public void CalculateUG()
        {
            TotalMarks=SemesterOne+SemesterTwo+SemesterThree+SemesterFour;
            Percentage=TotalMarks/4;
        }
        public void UpdateInfo(string name,string fatherName,long phone,DateTime dob,Gender gender,string adharNumber,String uGMarkSheetNumber,int physics,int chemistry,int maths,string hSCMarksheetNumber,double sem1,double sem2,double sem3,double sem4,DateTime dateOfApplication)
        {
            s_applicationID++;
            ApplicationID="AID"+s_applicationID;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            DOB=dob;
            AdharNumber=adharNumber;
            Gender=gender;
            UGMarkSheetNumber=uGMarkSheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
            HSCMarksheetNumber=hSCMarksheetNumber;
            SemesterOne=sem1;
            SemesterTwo=sem2;
            SemesterThree=sem3;
            SemesterFour=sem4;
            DateOfApplication=dateOfApplication;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine($"ApplicationID is    :{ApplicationID}");
            System.Console.WriteLine($"Name is             :{Name}");
            System.Console.WriteLine($"FatherName is       :{FatherName}");
            System.Console.WriteLine($"Phone is            :{Phone}");
            System.Console.WriteLine($"DOB is              :{DOB}");
            System.Console.WriteLine($"AdharNumber is      :{AdharNumber}");
            System.Console.WriteLine($"Gender is           :{Gender}");
            System.Console.WriteLine($"UGMarksheetNumber : {UGMarkSheetNumber}");
            System.Console.WriteLine($"PhysicsMark: {Physics}  ChemistryMark: {Chemistry}  MathsMark: {Maths}");
            System.Console.WriteLine($"HSCMarksheetNumber is: {HSCMarksheetNumber}");
            System.Console.WriteLine($"Semester1 is: {SemesterOne}  semester2 is: {SemesterTwo}  Semester3 is: {SemesterThree}  semester4 is: {SemesterFour}");
            System.Console.WriteLine($"DateOfApplication :{DateOfApplication.ToString("dd/MM/yyyy")}");

        }
        public void PayFees(int amount)
        {
            if(amount>500)
            {
                FeeStatus=FeeStatus.Paid;
            }
            else{
                FeeStatus=FeeStatus.Pending;
            }
        }
    }
}