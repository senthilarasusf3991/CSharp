using System;
namespace Question1
{
    public class FamilyInfo:PersonalInfo
    {
        public string MotherName { get; set; }
        public int NoOfSibilings { get; set; }
        public string NativePlace { get; set; }
        
        public FamilyInfo(string name,string fatherName,long mobile,string mailID,Gender gender,string motherName,int noOfSibilings,string nativePlace):base( name, fatherName, mobile, mailID, gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            MailID=mailID;
            Gender=gender;
            MotherName=motherName;
            NoOfSibilings=noOfSibilings;
            NativePlace=nativePlace;
            
        }
        public sealed override void Update(string name)
        {
            Name=name;
        }
        public sealed override void ShowInfo()
        {
            base.ShowInfo();
          
            System.Console.WriteLine($"MotherName      :{MotherName}");
            System.Console.WriteLine($"NoOf sibilings  :{NoOfSibilings}");
        }
    }
}