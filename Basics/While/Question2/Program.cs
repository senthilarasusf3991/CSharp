
using System;
namespace Question
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input count: ");
            int count= int.Parse(Console.ReadLine());
            int i=1;
            int temp=0;
            while (i<=count)
            
            {
                Console.WriteLine("Enter the number");
                int num=int.Parse(Console.ReadLine());

                i++;
                temp=temp+(num*num);

            }
            Console.WriteLine(temp);
        }
    }
}