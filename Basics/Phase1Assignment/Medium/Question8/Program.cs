
using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter a string: ");
            string newString=Console.ReadLine();
            string myNewString="";
            foreach(char i in newString)
            {
                if(i>=48 && i<=57)
                {
                    myNewString=myNewString+i;

                }
            }
            if(myNewString.Equals(""))
            {
                System.Console.WriteLine("No number is entered in the string");

            }
            else if(int.Parse(myNewString)%2==0)
            {
                System.Console.WriteLine($"{myNewString} is an even number");
            }
            else{
                System.Console.WriteLine($"{myNewString} is an odd number");
            }

        }
    }
}