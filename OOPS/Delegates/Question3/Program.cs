using System;
namespace Question3
;
public delegate double Calculator (double number1,double number2);
class program
{
    public static double Addition(double number1,double number2)
    {
        return number1+number1;
    }
    public static double Subtract(double number1, double number2)
    {
        return number1-number2;
    }
    public static double Multiply(double number1,double number2)
    {
        return number1*number2;
    }
    public static double Division(double number1,double number2)
    {
        return number1/number2;
    }
    public static void Main(string[] args)
    {
        Calculator add=new Calculator(Addition);
        double result=add(5,4);  //We are storing the return value in result
        System.Console.WriteLine($"The value is {result}");

        Calculator sub=new Calculator(Subtract);
        System.Console.WriteLine($"The value is {sub(5,4)}");  //we are directly printing the values without storing it in another variable

        Calculator mul= new Calculator(Multiply);
        System.Console.WriteLine($"The value is {mul(3,3)}");

        Calculator div=new Calculator(Division);
        System.Console.WriteLine($"The value is {div(4,4)}");

        //Multicasting
        Calculator calci=new Calculator(Addition);
        calci+=new Calculator(Subtract);
        calci+=new Calculator(Multiply);
        calci+=new Calculator(Division);
        System.Console.WriteLine($"The value of Multicasting method is {calci(9,9)}"); //It only returns the value of final method

        
    }
}