
using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the lower limit:");
            int lower =int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the upper limit:");
            int upperLimit =int.Parse(Console.ReadLine());
            double armstrong =0;
            int temp;
            int size;
            System.Console.WriteLine($"Armstrong number between {lower} to {upperLimit}");
            for(int i=lower;i<=upperLimit;i++)
            {
                size=Convert.ToString(i).Length;
                temp=i;
                armstrong=0;
                while(temp>0)
                {
                    armstrong=armstrong+Math.Pow(temp%10,size);
                    temp=temp/10;

                }
                if(armstrong==i)
                {
                    System.Console.Write(armstrong+" ");
                }

            }

        }
    }
}