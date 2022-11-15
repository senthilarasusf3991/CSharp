using System;
namespace Question1;
public delegate string Display();
class Program
{
    public static string Message()
    {
        return "Welcome to Syncfusion Technology";
    }
    public static string Message1()
    {
        return "Hello You are Welcome";
    }

    public static void Main(string[] args)
    {
        //Single Casting
        Display newMessage=new Display(Message);
        System.Console.WriteLine(newMessage());
        //MultiCasting

        Display newMessage1=new Display(Message);
        newMessage1+=new Display(Message1);
        System.Console.WriteLine(newMessage1());

        //function delegate
        System.Console.WriteLine(FunctionDelegate.FunctionDelegateMessage(FunctionDelegate.Message));
        System.Console.WriteLine(FunctionDelegate.FunctionDelegateMessage(FunctionDelegate.Message1));

        //Action Delegate
        Action<string,string> actObject=new Action<string, string>(ActionDelegate.Message);
        actObject("senthil","arasu");
    }
}