
using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            void fibo(int range1)
            {
                int temp=0;
                int a=0;
                int b=1;

                for (int i=0; i<range1;i++)
                {
                    System.Console.WriteLine(a);
                    temp=a+b;
                    a=b;
                    b=temp;
                }


            }
            System.Console.WriteLine("Enter the range: ");
            int range1=int.Parse(Console.ReadLine());

            fibo(range1);

         
        }
    }
}