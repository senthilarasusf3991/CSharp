using System;
namespace MultiPathInheritence
{
    class Student:ISport,IAcademic
    {
        public int AcadamicMark{get;set;}
        public string Name{get;set;}
        public int SportMark {get;set;}
        public Student(string name,int academicMark,int sportMark)
        {
            Name=name;     AcadamicMark=academicMark;     SportMark=sportMark;
        }
        public void Display()
        {
            System.Console.WriteLine("Name"+Name+"Total Mark"+(SportMark+AcadamicMark));
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student("senthil",90,91);
            student.Display();
            Console.ReadKey();
        }
    }

    
}