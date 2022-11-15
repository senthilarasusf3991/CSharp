
using System;
namespace Question
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool temp;
            int num;
            
            do
            {
                
                System.Console.WriteLine("Enter a  number: ");
                temp=int.TryParse(Console.ReadLine(),out num);
                if (temp==false )
                {
                    System.Console.WriteLine("invalid input enter the value again");  
                }
                else if (temp==true &&(num<0 || num>10))
                {
                    System.Console.WriteLine("invalid input enter the value again");
                    
                }

            }while(temp==false || (num<0 || num>10));
            System.Console.WriteLine("valid input");

        }
    }
}
