
using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            string temp="";
            System.Console.WriteLine("Enter the string: ");
            string nameone=Console.ReadLine();

            foreach (char check in nameone)
            {
                bool tocheck=temp.Contains(check);
                if (tocheck==false)
                {
                    temp=temp+check;
                }
                
                
        
            }System.Console.WriteLine($"Duplicate char {temp}");
            
            

        }
    }
}
