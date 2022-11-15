using System;
namespace FunctionDeligate;
class Program
{
    static double Sum(int number1, int number2) {return number1+number2;   }
    static double Subtract(int number1 ,int number2 ) {return number1-number2;}
    static double Calculator(Func<int, int, double>operation, int x, int y)
                                //a    //b   //returining //nc
    {
        return operation(x,y);

    }
    public static void Main(string[] args)
    {
        Func<int,int,double>operation = Sum;
        operation +=Subtract; //multicasting function delegate
        double result=operation(10,20); //it return a value , can take 16 arguments
        System.Console.WriteLine("Final results of add and subtract "+result);
        System.Console.WriteLine(Calculator(Sum,10,20));  //using delegates inside methods
        System.Console.WriteLine(Calculator(Subtract,10,20));
    }
}