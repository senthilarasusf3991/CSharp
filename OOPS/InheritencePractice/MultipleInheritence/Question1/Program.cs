using System;
namespace Question1;
class program
{
    public static void Main(string[] args)
    {
        RegisterPerson register =new RegisterPerson("senthil","balu","985747","senthil.mail",new DateTime(2000,10,22),Gender.Male,"jeya","ArasinamPatti",3,new DateTime(2022,06,06));
        System.Console.WriteLine("Before Update");
        register.ShowInfo();
        register.updateInfo("balu","baluarasu","985747","arasu.mail",new DateTime(2000,10,22),Gender.Male,"jeya","ArasinamPatti",3,new DateTime(2021,06,06));
        System.Console.WriteLine("After Update");
        register.ShowInfo();
        

    }
}