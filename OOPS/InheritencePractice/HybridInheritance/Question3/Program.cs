using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        float[]sem1={90,87,94,79,90,95};
        float[]sem2={90,98,90,67,96,95};
        float[]sem3={90,98,98,94,96,95};
        float[]sem4={97,89,96,97,96,95};

        RegisterApplication student=new RegisterApplication("2018308035",3,"Physics","b.tech","Pharma",sem1,sem2,sem3,sem4,"balu","vela","jeay","obb","980980980","balu@mail.com",Gender.Male);
        student.ShowInfo();
    }
}