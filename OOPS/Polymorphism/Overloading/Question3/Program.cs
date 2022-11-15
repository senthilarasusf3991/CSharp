using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        DisplayMethod display=new DisplayMethod();
        Console.WriteLine(display.Display(5));
        Console.WriteLine(display.Display(5.5));
        Console.WriteLine(display.Display(9.399856));
        Console.WriteLine(display.Display(9842383337));
        
    }
    
}