using System;
namespace Question3
{
    class Progarm
    {
        public static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                int cube=i*i*i;
                
                Console.WriteLine($"Number is {i} and cube of the {i} is :{cube}");
            }
        }
    }
}