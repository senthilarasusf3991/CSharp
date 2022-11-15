using System;
namespace Question2
{
    class Programe
    {
        public static void Main(string[] args)
        {
            int sum=0;
            for(int i=1;i<=10;i++)
            {
                
                sum=sum+i;
            }
            Console.WriteLine("sum: "+(sum));
            Console.WriteLine("average: "+(float)sum/10);

        }
    }
}