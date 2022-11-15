using System;
namespace Question1
{

    public enum Gender{Default, Male, Female, Transgender}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName{get;set;}
        public long Mobile { get; set; }
        public string MailID{get;set;}
        public Gender Gender { get; set; }

      
        public PersonalInfo(string name,string fatherName,long mobile,string mailID,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            MailID=mailID;
            Gender=gender;

        }
        public virtual void ShowInfo()
        {
            System.Console.WriteLine($"Name is             :{Name}");
            System.Console.WriteLine($"Gender is           :{Gender}");
            System.Console.WriteLine($"FatherName is       :{FatherName}");
            System.Console.WriteLine($"MobileNumber is     :{Mobile}");
            System.Console.WriteLine($"MailID              :{MailID}");
        }
                
        
        
        
        
        
        
    }
}