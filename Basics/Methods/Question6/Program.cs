
using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            void fact(int range1)
            {
                int factoraial=1;
                for (int i=range1;i>=1;i--)
                {
                    factoraial=factoraial*i;
                    
                }
                System.Console.WriteLine(factoraial);
            }
            System.Console.WriteLine("Enter the range: ");
            int range1=int.Parse(Console.ReadLine());  

            fact(range1);
        }
    }
}