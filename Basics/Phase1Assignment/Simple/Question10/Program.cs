
using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            System.Console.WriteLine("Enter the char: ");
            char character= char.Parse(Console.ReadLine().ToLower());
            
            

            if(character=='a' || character=='u' || character=='e' || character=='i' || character=='o'  )
            {
                System.Console.WriteLine("Its a vowel");

            }

            else{
                System.Console.WriteLine("Not a vowel");
            }

            
            
        }
    }
}