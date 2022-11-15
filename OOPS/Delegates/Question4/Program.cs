using System;
namespace Question4;
class program
{
    public static void Main(string[] args)
    {
        //FunctionDelegate func=new FunctionDelegate
        Func<double,double,double,double,double,double> avg=new Func<double, double, double, double, double, double>(FunctionDelegate.Average);
        System.Console.WriteLine($"Average is {avg(90,89,98,90,78)}");
    }
}