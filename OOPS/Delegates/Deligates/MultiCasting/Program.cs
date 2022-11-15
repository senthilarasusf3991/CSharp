
using System;


namespace MultiCasting

{
    public delegate int Calculator(int value); //can add methods having int return type and 1 int arg
    class Program
    {
        static int value =10;
        public static int Add(int number){ value+=number; return value;}
        public static int Multiply(int number){ value*= number; return value;}
        public static int GetNum(){ return value;}

        static void Main(string[] args) {
            //Multicasting 
            //create delegate instances or objects
            Calculator nc;
            nc=new Calculator(Add);
            nc+=new Calculator(Multiply);
            //calling multicast
            nc(5);
            System.Console.WriteLine("Value of Num: {0}", GetNum());
            Console.ReadKey();



        }

    }
    
}