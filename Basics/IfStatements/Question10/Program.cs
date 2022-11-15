using System;
namespace Question10;
class Program
{
    public static void Main(string[] args)
    {
        string Default="HiTeam";
        Console.WriteLine("Enter the input: ");
        string word = Console.ReadLine();
        if (Default==word)
        {
            System.Console.WriteLine("Right password ");
        }
        else
        {
            System.Console.WriteLine("Wrong password");
        }
        
    }
}