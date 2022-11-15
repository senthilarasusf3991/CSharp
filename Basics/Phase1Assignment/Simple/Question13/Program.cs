
using System;
namespace Question13
{
    class Program
    {

        public static void Main(string[] args)
        {
            int multi;
            System.Console.WriteLine("Enter the table: ");
            int table=int.Parse(Console.ReadLine());

            for(int i=0;i<=20;i++)
            {
                multi=table*i;
                System.Console.WriteLine($"{table} * {i} ={multi}");
            }
            
        }
    }
}
