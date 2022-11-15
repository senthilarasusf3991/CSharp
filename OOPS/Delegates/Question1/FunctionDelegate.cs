using System;
namespace Question1
{
    public class FunctionDelegate
    {
        public static string Message()
        {
            return "Welcome to Syncfusion Technology";
        }
        public static string Message1()
        {
            return "Hello";
        }
        public static string FunctionDelegateMessage(Func<string>operation)  //method
        {
            return operation();
        }
    }
}