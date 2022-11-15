using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        { 
            
            for(int i=1;i<=4;i++)
            {
                for(int s=i;s<4;s++)
                {
                    Console.Write(" ");

                }
                for(int j=1;j<i+1*(i);j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}