
using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            string pass="";
            string password="s3cr3t!P@ssw0rd";
            System.Console.WriteLine("Enter the password: ");
            string check=Console.ReadLine();
            
            for (int i=0;i<check.Length;i++)
            {
                pass=pass+check[i];
               

            }
            if(pass==password)
            {
                System.Console.WriteLine("Welcome");
            }
            else{
                System.Console.WriteLine("Wrong password");
            }

 
            
            
        }
    }
}