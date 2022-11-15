using System;
namespace ReadWriteCSV
{
    public enum Gender{Default, Male, Female}
    public class Student
    {
        public string Name{get; set;}
        public string FatherName{get;set;}
        public Gender Gender{get;set;}
        public DateTime DOB{get;set;}
    }
}