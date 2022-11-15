using System;
namespace Question1
{
    public enum Gender{Defalut, Male, Female, TransGender}
    public class PersonalInfo
    {
        public string RegistrationNumber{get;set;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public long PhoneNumber{get;set;}
        public DateTime DOB {get;set;}
        public Gender Gender{get;set;}
        public PersonalInfo(string registrationNumber,string name, string faterName,long phoneNumber, DateTime dOB, Gender gender)
        {
            RegistrationNumber=registrationNumber;
            Name=name;
            FatherName=faterName;
            PhoneNumber=phoneNumber;
            DOB=dOB;
            Gender=gender;
            
        }
        public void ShowPersonalInfo()
        {
            System.Console.WriteLine($"Name is               :{Name}");
            System.Console.WriteLine($"FatherName is         :{FatherName}");
            System.Console.WriteLine($"PhoneNumber is        :{PhoneNumber}");
            System.Console.WriteLine($"DOB is                :{DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"Gender is             :{Gender}");
            System.Console.WriteLine($"RegistrationNumber is :{RegistrationNumber}");
        }
    }
}