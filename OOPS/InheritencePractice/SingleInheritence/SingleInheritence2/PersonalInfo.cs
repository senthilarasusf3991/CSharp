using System;
namespace SingleInheritence2
{
    public enum Gender{Default, Male, Female, Transgender}
    public class PersonalInfo
    {
        public string Name{get;set;}
        public string FatherName {get;set;}
        public long PhoneNumber{get; set;}
        public string Mail{get; set;}
        public DateTime DOB {get;set;}
        public Gender HolderGender{get;set;}

        public PersonalInfo(string name, string fatherName, long phonenumber,string mail,DateTime dOB, Gender holderGender)
        {
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phonenumber;
            Mail=mail;
            DOB=dOB;
            HolderGender=holderGender;
        }


    }
}