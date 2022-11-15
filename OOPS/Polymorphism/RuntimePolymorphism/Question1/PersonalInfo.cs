namespace Question1
{

    public enum Gender{Default, Male, Female, Transgender}
    public abstract class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long MobileNumber { get; set; }
        public Gender Gender{get;set;}
        public PersonalInfo(string name,string fatherName,long mobileNumber,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            MobileNumber=mobileNumber;
            Gender=gender;
        }
        public void ShowPersonalInfo()
        {
            System.Console.WriteLine($"Name       :{Name}");
            System.Console.WriteLine($"FatherName :{FatherName}");
            System.Console.WriteLine($"Mobile     :{MobileNumber}");
            System.Console.WriteLine($"Gender     :{Gender}");
        }
        public abstract void Display();
        
        
        
    }
}