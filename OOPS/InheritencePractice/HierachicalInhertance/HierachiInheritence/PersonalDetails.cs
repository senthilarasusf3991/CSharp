using System;
namespace HierachiInheritence
{
    public enum Gender{Default, Male, Female, Transgender}
    public class PersonalDetails
    {
        private static int s_aID=1000;
        public string AID{get;set;}
        public string Name{get; set;}
        public string FatherName{get;set;}
        public Gender HolderGender{get;set;}
        public DateTime DOB{get;set;}
        public PersonalDetails( string name, string fatherName, Gender holderGender, DateTime dob)
        {
            s_aID++;
            AID="AD"+s_aID;
            Name=name;
            FatherName=fatherName;
            HolderGender=holderGender;
            DOB=dob;

        }
        public PersonalDetails(string aID, string name, string fatherName, Gender holderGender, DateTime dob)
        {
            AID=aID;
            Name=name;
            FatherName=fatherName;
            HolderGender=holderGender;
            DOB=dob;

        }
        public PersonalDetails()
        {

        }
        
        public  void ShowDetails()
        {
            System.Console.WriteLine(($"AID is {AID}"));
            System.Console.WriteLine(($"Name is {Name}"));
            System.Console.WriteLine(($"FatherName is {FatherName}"));
            System.Console.WriteLine(($"Gender is {HolderGender}"));
            System.Console.WriteLine($"dob is {DOB.ToString("dd/MM/yyyy")}");



        }

        

    }
}