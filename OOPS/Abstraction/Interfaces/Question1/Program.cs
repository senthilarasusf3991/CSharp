using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        Dog myDog=new Dog("GermanShepherd","Land","Meat");
        myDog.DisplayName();
        Duck myDuck=new Duck("Duck","Water","duck foods");
        myDuck.DisplayName();
    }
}