using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        PGCancelling student=new PGCancelling("senthil","balu",9842393338,new DateTime(2000,10,04),Gender.Male,"311616867038","1125463",98,98,98,"112435",9,8,7,9,DateTime.Today);
        System.Console.WriteLine("Before Update");
        student.ShowInfo();
        System.Console.WriteLine("After Update");
        student.UpdateInfo("senthilarasu","Balu",9629254088,new DateTime(2001,04,04),Gender.Male,"311616867038","989898",98,98,98,"838942",9,8,7,9,DateTime.Today);
        student.ShowInfo();
    }
}