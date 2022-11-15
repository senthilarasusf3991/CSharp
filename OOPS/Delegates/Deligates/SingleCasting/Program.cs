
using System;


namespace SingleCasting

{
    public delegate int Calculator(int value); //can add methods having int return type and 1 int arg
    class Program
    {
        static int value =10;
        public static int Add(int number){ value+=number; return value;}
        public static int Multiply(int number){ value*= number; return value;}
        public static int GetNum(){ return value;}

        static void Main(string[] args) {
            //create delegate instances or Objects
            Calculator nc1=new Calculator(Add);
            Calculator nc2=new Calculator(Multiply);
            //Calling methods directly
            System.Console.WriteLine("Output "+Add(10));
            //calling the methods using the delegate objects
            System.Console.WriteLine("output"+nc1(25));
            System.Console.WriteLine("value of Num:{0}",GetNum());
            System.Console.WriteLine("Output"+nc2(5));
            System.Console.WriteLine("value of Num{0}",GetNum());
            Console.ReadKey();


        }

    }
    
}