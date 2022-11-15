using System;
class Student
{
    public string Name{get; set;}
    public int TotalMarks{get;set;}
    public virtual void Display(){}
}
class Sport:Student
{
    public int SportMark=50;
    public override void Display()
    {
        System.Console.WriteLine("Name"+Name+"Mark "+SportMark);
    }
}
class Total:Sport{
    public int AcedamicMark =90; public string StudentName {get;set;}
    public override void Display()
    {
        TotalMarks =AcedamicMark +SportMark;
        System.Console.WriteLine("Name "+Name +"Mark: "+TotalMarks);
    }
     
}
internal class Program
{
    public static void Main(string[] args)
    {
        Total total = new Total();
        total.AcedamicMark=90;

        Student student;
        student =total;

        student.Name="ravi";
        student.Display();

        Student sport = new Student();
        student = sport;
        student.Name="chandran";
        student.Display();


    }
}