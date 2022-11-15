using System;
namespace Question1
{
    public enum Gender{Default,Male,Female,Others}
    public interface PersonalInfo
    {
        public string AdharNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
         
    }
}