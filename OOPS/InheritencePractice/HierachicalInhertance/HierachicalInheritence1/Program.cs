
using System;
using System.Collections.Generic;
namespace HierachicalInheritence1;
class Program{
    public static void Main(string[] args)
    {
        
        List<StudentInfo>studentList=new List<StudentInfo>();
        List<Teacher>teacherList=new List<Teacher>();
        List<PrincipalInfo>principalList=new List<PrincipalInfo>();
        StudentInfo student1=new StudentInfo("Senthil","Balu","9627354766","senthil@mail.com",Gender.Male,"B.Tech","Pharma","I");
        StudentInfo student2=new StudentInfo("Mathi","Mani","9876345267","mathi@mail.com",Gender.Male,"B.Tech","Pharma","I");
        studentList.Add(student1);
        studentList.Add(student2);

        Teacher teacher1=new Teacher("Shanthi","Rakshan","7648923415","shanthi@gmail.com",Gender.Female,"BioTech","Solid Dosage Forms","B.TECH",3,new DateTime(2022,01,02));
        Teacher teacher2=new Teacher("sumathi","Ravi","9835094785","sumathi@gmail.com",Gender.Female,"BioTech","Solid Dosage Forms","B.TECH",3,new DateTime(2022,01,02));
        teacherList.Add(teacher1);
        teacherList.Add(teacher2);

        PrincipalInfo principal1=new PrincipalInfo("Sundhar","Raman","98337530","sundhar@mail.com",Gender.Male,"FoodTech",10,new DateTime(2012,01,02));
        PrincipalInfo principal2=new PrincipalInfo("Pichai","Rangan","947999430","pichai@mail.com",Gender.Male,"FoodTech",10,new DateTime(2012,01,02));
        principalList.Add(principal1);
        principalList.Add(principal2);

        foreach(StudentInfo student in studentList)
        {
            if(student.StudentID=="SID102")
            {
                System.Console.WriteLine("------Before update----");
                student.ShowStudentInfo();
                System.Console.WriteLine("------After update------");
                student.Update("Mathi","Mani","7685940930","mathi@mail.com",Gender.Male,"B.Tech","FoodProcessing","I");
                student.ShowStudentInfo();
            }
        }
        foreach(Teacher teacher in teacherList)
        {
            if(teacher.TeacherID=="TID102")
            {
                System.Console.WriteLine("-------------Before update------------");
                teacher.ShowInfo();
                teacher.Update("sumathi","Ravi","9835094785","sumathiravi@gmail.com",Gender.Female,"BioTech","Sterile","B.TECH",3,new DateTime(2022,01,02));
                System.Console.WriteLine("----------After update---------");
                teacher.ShowInfo();
            }
        }
        foreach(PrincipalInfo principal in principalList)
        {
            System.Console.WriteLine(principal.PrincipalID);
            if(principal.PrincipalID=="PID101")
            {
                System.Console.WriteLine("------Before update------");
                principal.ShowInfo();
                principal.Update("Sundhar","Raman","6875647883","sundharraman@mail.com",Gender.Male,"PharmaTech",10,new DateTime(2012,01,02));
                System.Console.WriteLine("------------After update-----");
                principal.ShowInfo();
            }
        }
        



    }
}