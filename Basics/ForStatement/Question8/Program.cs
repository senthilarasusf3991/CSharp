using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num=1;
            for (int i=1;i<=4;i++)
            {
                for (int s=i;s<4;s++)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<i+1;j++)
                {
                    Console.Write(num+" " );
                    num=num+1;
                }
                Console.WriteLine();
            }
        }
    }
}