using System;
namespace HierachicalInheritence1
{
    public enum Gender{Default,Male,Female,Others}
    public class PersonalInfo
    {
        
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public Gender HolderGender { get; set; }
        public PersonalInfo(string name,string fatherName,string phone,string mail,Gender gender)
        {
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            HolderGender=gender;
        }
        public void ShowPersonalInfo()
        {
            Console.WriteLine("Name         :"+Name);
            Console.WriteLine("Father name  :"+FatherName);
            Console.WriteLine("Phone        :"+Phone);
            Console.WriteLine("Mail         :"+Mail);
            Console.WriteLine("Gender       :"+HolderGender);
        }
    }
}