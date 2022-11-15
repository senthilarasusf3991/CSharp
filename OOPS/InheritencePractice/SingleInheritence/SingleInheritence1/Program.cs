
using System;
using System.Collections.Generic;
namespace SingleInheritence1
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            List<StudentInfo> studentList=new List<StudentInfo>();
            StudentInfo student1=new StudentInfo("senthil","balu",9629254040,"senthil@gmail.com",new DateTime(2020,10,05),Gender.Male,Standard.FirstYear,Branch.Pharma,new DateTime(2021,10,05));
            studentList.Add(student1);
            StudentInfo student2=new StudentInfo("priyan","ravi",9629574040,"priyan@gmail.com",new DateTime(2017,07,09),Gender.Male,Standard.FirstYear,Branch.Food,new DateTime(2021,11,06));
            studentList.Add(student2);
            StudentInfo student3=new StudentInfo("mathi","mari",9829454040,"mathi@gmail.com",new DateTime(2019,08,05),Gender.Male,Standard.FirstYear,Branch.Biotech,new DateTime(2021,10,07));
            studentList.Add(student3);
            StudentInfo student4=new StudentInfo("arun","aari",9629267887,"arun@gmail.com",new DateTime(2018,11,05),Gender.Male,Standard.FirstYear,Branch.Pharma,new DateTime(2021,11,13));
            studentList.Add(student4);
            foreach(StudentInfo student in studentList)
            {
                if(student.RegistrationNumber.Equals("SID201"))
                {
                    System.Console.WriteLine("-----BEFORE UPDATE-----");
                    student.StudentInformation();
                    System.Console.WriteLine("-----AFTER UPDATE-----");
                    student.UpdateInfo("senthil","balu",9874536290,"senthil@gmail.com",new DateTime(2020,10,05),Gender.Male,Standard.Secondyear,Branch.Pharma,new DateTime(2021,10,05));
                    student.StudentInformation();


                }
            }
        }
    }
}