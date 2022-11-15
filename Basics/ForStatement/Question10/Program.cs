using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num=int.Parse(Console.ReadLine());
            bool temp=true;
            for(int i =2;i<num;i++)
            {
                if (num%i==0)
                {
                    Console.WriteLine($"{num} is not a pime number");
                    temp=false;
                    break;

                }
                
                

            }
            if(temp)
            {
                Console.WriteLine($"{num} is a pime number");
            }

        }
    }
}
