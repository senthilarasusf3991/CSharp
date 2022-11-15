
using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int count=0;
            System.Console.WriteLine("Enter the string: ");
            string name=Console.ReadLine();
            for(int i=0; i<50; i++)
            {
                try{
                    char n = name[i];
                    count++;
                }
                catch(Exception)
                {
                    break;
                }
            }
            System.Console.WriteLine(count);

            //foreach
            int temp=0;
            System.Console.WriteLine("Enter the string: ");
            string str=Console.ReadLine();
            foreach(char len in str)
            {
                temp++;
            }
            System.Console.WriteLine(temp);
            
        }
        
    }
}