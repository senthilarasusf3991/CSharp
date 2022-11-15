using System;
namespace Question1
{
    public class program
    {
        public static void Main(string[] args)
        {
            
        
            EEEDepartment eEEBook=new EEEDepartment("Senthil","Csharp","balu",new DateTime (2000,10,12));
            CSEDepartment cSEBook=new CSEDepartment("Senthil","Csharp","balu",new DateTime (2000,10,12));
            System.Console.WriteLine("EEE Department");
            System.Console.WriteLine("Before Update");
            eEEBook.DisplayInfo();
            System.Console.WriteLine("After Update");
            eEEBook.SetBookInfo("arasu","Python","aari",new DateTime (2000,10,12));
            eEEBook.DisplayInfo();

            System.Console.WriteLine("CSE Department");
            System.Console.WriteLine("Before Update");
            cSEBook.DisplayInfo();
            System.Console.WriteLine("After Update");
            cSEBook.SetBookInfo("Arasu","Python","aari",new DateTime (2000,10,12));
            cSEBook.DisplayInfo();




        }


    }
}