using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num=int.Parse(Console.ReadLine());
            int armstrong=0;
            int temp;
            for(temp=num;temp>0;temp=temp/10)
            {
                armstrong=armstrong+(temp%10)*(temp%10)*(temp%10);

            }
            if (armstrong==num)
            {
                Console.WriteLine($"{num} is armstrong number");
            }
            else
            {
                Console.WriteLine($"{num} is not armstrong number");
            }
        }
    }
}