
using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number=int.Parse(Console.ReadLine());
            int temp =number;
            int sum=0;  //adding  the remainder gives the sum of digit
            while(number>0) //till we getting the positive quotient value we should get the reamainder and add it in sum
            {
                sum=sum+number%10; //getting the ramainder and adding it
                number=number/10;  //dividing the number to get quotient 

            }
            System.Console.WriteLine($"sum of digit of {temp} is {sum}");
        }
    }
}