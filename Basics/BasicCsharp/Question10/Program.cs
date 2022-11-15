using System;
namespace Question;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter value1: ");
        int value1=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value2: ");
        int value2=int.Parse(Console.ReadLine());

        Console.WriteLine("a."+ (value1>value2));
        Console.WriteLine("b."+(value1<value1));
        Console.WriteLine("c."+ (value1>=value2));
        Console.WriteLine("d."+ (value1==value2));
        Console.WriteLine("e."+ (value1!=value2));
        Console.WriteLine("f."+ (value1<=value2));
        Console.WriteLine("g."+ (value1>=10 && value2>=10));
        Console.WriteLine("h."+ (value1>=10 || value2>=30));
        Console.WriteLine("i."+ !(value1>20));

        string value=value1==15?"true":"false";
        Console.WriteLine("j."+(value));
        Console.WriteLine("k."+(value1++));
        Console.WriteLine("l."+(value1--));

        Console.ReadLine();
        

    }
}