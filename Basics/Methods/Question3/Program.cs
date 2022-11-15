
using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            void swap(int num1,int num2)
            {
                int temp=0;
                temp=num1;
                num1=num2;
                num2=temp;

                System.Console.WriteLine(num1+","+num2);  //WriteLine can have only one variable so we are combaining with a stirng
                

            }


            Console.WriteLine("Enter the num1: ");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the num2: ");
            int num2=int.Parse(Console.ReadLine());

            swap(num1, num2);


        }
    }
}
