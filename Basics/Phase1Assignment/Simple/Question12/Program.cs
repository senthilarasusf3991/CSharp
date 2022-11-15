
using System;
namespace Question12
{
    class Program
    {

        public static void Main(string[] args)
        {
            int  square=0;
            
            System.Console.WriteLine("Enter the number: ");
            int range=int.Parse(Console.ReadLine());

            for(int i=1;i<=range;i++)
            {
                if (i%2==1)
                square=square+(i*i);
            }
            System.Console.WriteLine(square);
         

            

            
            
        }
    }
}
