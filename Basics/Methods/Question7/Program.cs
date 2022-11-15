
using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            void check(string pali)
            {
            string rev="";

            for (int i=pali.Length-1;i>=0;i-- )
            {
                rev += pali[i];
            }
            if (rev==pali)
            {
                System.Console.WriteLine("Palindrome");
            } else {
                System.Console.WriteLine("not a Palindrome");
            }

            }
            System.Console.WriteLine("Enter the string: ");
            string pali=Console.ReadLine();
            check(pali);
            

        }
    }
}
