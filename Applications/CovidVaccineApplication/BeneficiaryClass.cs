using System;
namespace CovidVaccineApplication
{
    public enum Gender{Default, Male, Female, Transgender}
    public class BeneficiaryClass
    {
        private static  int s_registrationID=1000;
        public string RegistrationID{get;}
        public string Name {get; set;}
        public Gender HolderGender{get; set;}
        public string MobileNO{get; set;}
        public string City{get; set;}
        public int  Age{get;set;}

     public BeneficiaryClass(string name,Gender gender,string mobileNO,string city,int age)
     {
        s_registrationID++;
        RegistrationID="BID"+s_registrationID;
        Name=name;
        HolderGender=gender;
        MobileNO=mobileNO;
        City=city;
        Age=age;



     }

    }
}