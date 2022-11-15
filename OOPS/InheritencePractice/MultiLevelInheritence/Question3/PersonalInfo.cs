using System;
namespace Question3
{
    public enum Gender{Default,Male,Female,Others}
    public class PersonalInfo:Attendance
    {

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }
        public PersonalInfo(string name,string phone,string mail,Gender gender,int NoOfHoursWorked)
        {
            Name=name;
            Phone=phone;
            Mail=mail;
            Gender=gender;
        }
        public void ShowPersonalInfo()
        {
            Console.WriteLine($"Name is       :{Name}");
            Console.WriteLine($"Phone is       :{Phone}");
            Console.WriteLine($"MailID is        :{Mail}");
            Console.WriteLine($"Gender is      :{Gender}");
        }
    }
}