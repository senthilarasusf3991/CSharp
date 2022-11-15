using System;
namespace SingleInheritence1
{
    public enum Gender{Default, Male, Female, Transgender}
    public class PersonalInfo
    {
        
        public string Name{get; set;}
        public string FatherName{get;set;}
        public long PhoneNumber{get;set;}
        public string MailID{get;set;}
        public DateTime DOB{get;set;}
        public Gender HolderGender{get;set;}
        public PersonalInfo(string name,string fatherName,long phoneNumber, string mailID, DateTime dob,Gender holderGender)
        {
            
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phoneNumber;
            MailID=mailID;
            DOB=dob;
            HolderGender=holderGender;
        }
    }
}