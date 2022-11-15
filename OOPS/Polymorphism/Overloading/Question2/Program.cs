using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        DisplayMethod display=new DisplayMethod();
        Console.WriteLine(display.Display(5));
        Console.WriteLine(display.Display(5,5));
        display.Display(1,"str");
        display.Display(1,"sen",100.5);
        


    }
}