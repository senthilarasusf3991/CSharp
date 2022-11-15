
using System;
namespace Question
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the username: ");
            string username=Console.ReadLine();
            System.Console.WriteLine("Enter the password: ");
            string password=Console.ReadLine();
            if(username.Equals("user") && password.Equals("pass"))
            {
                System.Console.WriteLine("Password entered successfully");
            }
            else{
                System.Console.WriteLine("Password entered is wrong");
            }




        }
    }
}
