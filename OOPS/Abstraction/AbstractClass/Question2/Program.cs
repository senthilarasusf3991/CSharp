using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        EEEDepartment eEEBook=new EEEDepartment("senthil","java","balu",new DateTime(1999,07,04));
        CSEDepartment cSEBook=new CSEDepartment("arasu","Python","saravana",new DateTime(1999,11,12));
        System.Console.WriteLine("------EEE Department------");
        System.Console.WriteLine("-----Before Update------");
        eEEBook.DisplayInfo();
        System.Console.WriteLine("-----After Update-----");
        eEEBook.SetBookInfo("balu","Python","vella",new DateTime(2000,09,04));
        eEEBook.DisplayInfo();
        System.Console.WriteLine("-----CSE Department-----");
        System.Console.WriteLine("-----Before Update-----");
        cSEBook.DisplayInfo();
        System.Console.WriteLine("-----After Update-----");
        cSEBook.SetBookInfo("arasu","Python","saravana",new DateTime(2000,05,11));
        cSEBook.DisplayInfo();

    }
}