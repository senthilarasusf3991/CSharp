using System;
using System.Collections.Generic;
namespace MultiLevelInheritence1;
class Program{
    public static void Main(string[] args)
    {
        List<HSCDetails> studentList=new List<HSCDetails>();
        HSCDetails student1=new HSCDetails("senthil","balu","962935647","senthil@mail.com",new DateTime(2001,04,04),Gender.Male,"FOURTH","BioTech",new DateTime(2022),1125463,90,99,100);
        HSCDetails student2=new HSCDetails("priyan","aaru","9629356469","priyan@mail.com",new DateTime(2001,04,04),Gender.Male,"FOURTH","BioTech",new DateTime(2022),1126453,87,99,98);
        studentList.Add(student1);
        studentList.Add(student2);
        foreach(HSCDetails student in studentList)
        {
            if(student.RegisterNumber.Equals("STD1001"))
            {
                System.Console.WriteLine("-------BEFORE UPDATE--------------");
                student.ShowInfo();
                student.UpdateInfo("senthil","balu","962925465","senthilarasu@mail.com",new DateTime(2001,04,04),Gender.Male,"FOURTH","BioTech",new DateTime(2022));
                System.Console.WriteLine("-------------AFTER UPDATE-----------");
                student.ShowInfo();
                student.TotalMarks();
                student.Percentage();
                student.ShowMarksheet();
            }
        }
    }
}