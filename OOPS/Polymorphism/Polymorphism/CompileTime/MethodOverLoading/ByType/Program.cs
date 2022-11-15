using System;
namespace ByType;
class Program
{
    //method with one parameter
    static void Display(int number1, int number2)
    {
        System.Console.WriteLine("Arguments: "+number1+" and "+number2);
    }
    //method with two parameter
    static void Display(string name)
    {
        System.Console.WriteLine("string Type "+ name);
    }
    public static void Main(string[] args)
    {
        Display(100,200);
        Display("senthil");
        Console.ReadLine();
        
    }

}
