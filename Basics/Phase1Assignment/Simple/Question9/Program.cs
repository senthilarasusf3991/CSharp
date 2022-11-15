
using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            int leavesTaken;
            int salary;
            System.Console.WriteLine("Enter the month: ");
            string month=(Console.ReadLine()).ToLower();
            
            switch(month)
            {
                case "january":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(31-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;
                    
                    
                    

                }
                case "feburary":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(28-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;

                }
                case "march":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(31-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;

                }
                case "april":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(30-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;

                }
                case "may":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(31-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;

                }
                case "june":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(30-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;

                }
                case "july":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(31-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;

                }
                case "august":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(31-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;

                }
                case "september":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(30-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;

                }
                case "october":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(31-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;

                }
                case "november":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(30-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;

                }
                case "december":
                {
                    System.Console.WriteLine("Enter the leavedays: ");
                    leavesTaken=int.Parse(Console.ReadLine());
                    salary=(31-leavesTaken)*(500);
                    System.Console.WriteLine(salary);
                    break;

                }
                default:
                {
                    System.Console.WriteLine("invalid month");
                    break;
                }

            }
            


            
        }
    }
}