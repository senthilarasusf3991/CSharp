using System;
namespace Question1
{
    public class RegisterPerson:PersonalInfo,IShowData,IFamilyInfo
    {
        public static int s_registrationNumber=1000;
        public string RegistrationNumber{get;}
        public DateTime DateOfRegistration{get;set;}
        
        public string MotherName{get;set;}
        public string HouseAdress{get;set;}
        public int NoOfSibilings{get;set;}
        public RegisterPerson(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,string mothername,string houseAdress,int noOfSibilings,DateTime dateOfRegistration):base( name, fatherName, phone, mail, dob, gender)
        {
            s_registrationNumber++;
            RegistrationNumber="RID"+s_registrationNumber;
            DateOfRegistration=dateOfRegistration;
            MotherName=mothername;
            HouseAdress=houseAdress;
            NoOfSibilings=noOfSibilings;


        }
        public void updateInfo(string name,string fatherName,string phone,string mail,DateTime dob,Gender gender,string mothername,string houseAdress,int noOfSibilings,DateTime dateOfRegistration)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            Gender=gender;
            DOB=dob;
            DateOfRegistration=dateOfRegistration;
            MotherName=mothername;
            HouseAdress=houseAdress;
            NoOfSibilings=noOfSibilings;
        }
        public void ShowInfo()
        {
            System.Console.WriteLine($"Name is      :{Name}");
            System.Console.WriteLine($"Father Name is      :{FatherName}");
            System.Console.WriteLine($"RegisterNumber is  :{RegistrationNumber}");
            System.Console.WriteLine($"Date of Registration is  :{DateOfRegistration.ToString("dd/MM/yyyy")}");
        }
    }
}