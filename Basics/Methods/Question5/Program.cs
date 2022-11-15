
using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            void check(int number)
            {
                bool flag =false;

                for(int i=2;i<number;i++)
                {
                    if(number%i==0)
                    {
                        flag = true;
                    }


                }
                if (flag==true)
                {
                    System.Console.WriteLine("Not prime");
                }
                else
                {
                    System.Console.WriteLine("Number is prime");
                }
            }
            System.Console.WriteLine("Enter the number: ");
            int number=int.Parse(Console.ReadLine());

            check(number);

            
        }
    }
}
