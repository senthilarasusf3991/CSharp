using System;
namespace Question1;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine(Display(5));
        Console.WriteLine(Display(5,10));
        Console.WriteLine(Display(2,5,9));
        Console.WriteLine(Display("senthilarasu","balu"));
        Console.WriteLine(Display("senthil","arasu","balu"));
    }
    public static int Display(int num)
    {
        return num*num;
    }
    public static int Display(int num1,int num2)
    {
        return num1*num2;
    }
    public static int Display(int num1,int num2,int num3)
    {
        return num1*num2*num3;
    }
    public static string Display(string str1,string str2)
    {
        return str1+str2;
    }
    public static string Display(string str1,string str2,string str3)
    {
        return str1+str2+str3;
    }
}