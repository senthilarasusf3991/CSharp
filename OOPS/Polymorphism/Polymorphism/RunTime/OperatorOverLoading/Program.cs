using System;
namespace OperatorOverLoading;

    class program
    {
        public static void Main(string[] args)
        {
            Box box1=new Box(10,12,14);
            Box box2=new Box(12,15,23);
            System.Console.WriteLine("Volume is"+box1.CalculateVolume());
            System.Console.WriteLine("Volume is"+box2.CalculateVolume());

            Box box3;
            box3=box1+box2;
            System.Console.WriteLine("Volume is "+box3.CalculateVolume());

            
        }
    }
