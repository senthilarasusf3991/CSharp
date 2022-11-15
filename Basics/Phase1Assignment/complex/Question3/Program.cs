
using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string: ");
            string nameone=Console.ReadLine();
            System.Console.WriteLine("Enter the string: ");
            string nametwo=Console.ReadLine();
            char[] char1=nameone.ToLower().ToCharArray();
            char[] char2=nametwo.ToLower().ToCharArray();

            Array.Sort(char1);
            Array.Sort(char2);

            string check1= new string(char1);
            string check2= new string(char2);

            if (check1==check2)
            {
                System.Console.WriteLine("Name one and two are anagrams");
            }
            else{
                System.Console.WriteLine("not Anagrams");
            }

            
            
        }
    }
}

