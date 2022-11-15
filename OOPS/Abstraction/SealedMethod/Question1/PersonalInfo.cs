using System;
namespace Question1
{

    public enum Gender{Default,Male,Female,Transgender}

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
            System.Console.WriteLine($"Name                :{Name}");
            System.Console.WriteLine($"Father Name         :{FatherName}");
            System.Console.WriteLine($"Mobile              :{Mobile}");
            System.Console.WriteLine($"MailId              :{MailID}");
            System.Console.WriteLine($"Gender              :{Gender}");
            

        }
        public virtual void Update(string name)
        {
            Name=name;
        }
                
        
        
        
        
        
        
    }
}