
using System;
namespace Question12
{
    class Program
    {

        public static void Main(string[] args)
        {
            
            
            System.Console.WriteLine("Enter the number: ");
            int number=int.Parse(Console.ReadLine());
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
    }
}
