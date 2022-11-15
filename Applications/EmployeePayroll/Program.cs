
using System;
using System.Collections.Generic;
namespace EmployeePayroll
{
    class Program
    {
        static List<EmployeePayrollManagement> employeeList=new List<EmployeePayrollManagement>();
        public static void Main(string[] args)
        {
            
            int option;
            do
            {

                System.Console.WriteLine("1.Registration 2.Login 3.Exit");
                option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Login();
                        break;
                    }
                    case 3:
                    {
                        
                        break;
                    }
                    default :
                    {
                        System.Console.WriteLine("Invalid choice enter again: ");
                        break;
                    }
                }
            }while(option!=3);


            static void Registration()
            {
                gender holderGender=gender.Default;
                System.Console.WriteLine("Enter your name: ");
                string name=Console.ReadLine();
                System.Console.WriteLine("Enter your role: ");
                string role=Console.ReadLine();
                System.Console.WriteLine("Enter your worklocation: ");
                string workLocation=Console.ReadLine();
                System.Console.WriteLine("Enter your team name: ");
                string teamName=Console.ReadLine();
                System.Console.WriteLine("Enter your date of joining: ");
                DateOnly dateOfJoining  = DateOnly.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the number of working days: ");
                int numberOfWorkingDays=int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter the number of leaves taken: ");
                int numberOfLeavesTaken=int.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your gender: ");
                while(!Enum.TryParse<gender> (Console.ReadLine(),true,out holderGender) || !(((int)holderGender>0) && ((int)holderGender<4)))
                    System.Console.WriteLine("Invalid entry Enter again");

                EmployeePayrollManagement detail = new EmployeePayrollManagement(name,role,workLocation,teamName,dateOfJoining,numberOfWorkingDays,numberOfLeavesTaken,holderGender);
                employeeList.Add(detail);
                System.Console.WriteLine("Your employee id is"+detail.EmployeeID);


                
            }
            static void Login()
            {
                int submenu;
                System.Console.WriteLine("Enter your employee id: ");
                string employeeID=Console.ReadLine();
                foreach(EmployeePayrollManagement employee in employeeList)
                {
                    if (employeeID.Equals(employee.EmployeeID))
                    {
                        do
                        {
                            System.Console.WriteLine("User found");
                            System.Console.WriteLine("1.Calculate salary 2.Display details 3.Exit");
                            submenu=int.Parse(Console.ReadLine());
                            switch(submenu)
                            {
                                case 1:
                                {
                                    System.Console.WriteLine("your salary is: ");
                                    Console.WriteLine(employee.SalaryCalculation(500));
                                    break;
                                }
                                case 2:
                                {
                                    System.Console.WriteLine(employee.Name);
                                    System.Console.WriteLine(employee.Role);
                                    System.Console.WriteLine(employee.WorkLocation);
                                    System.Console.WriteLine(employee.TeamName);
                                    System.Console.WriteLine(employee.DateOfJoining);
                                    System.Console.WriteLine(employee.NumberOfWorkingDays);
                                    System.Console.WriteLine(employee.NumberOfLeavesTaken);
                                    System.Console.WriteLine(employee.Gender);
                                    System.Console.WriteLine(employee.EmployeeID);
                                    
                                    

                                    break;
                                }
                                case 3:
                                {
                                    
                                    break;
                                }
                                default :
                                {
                                    System.Console.WriteLine("Invalid choice");
                                    break;
                                }
                                

                            }
                        }while(submenu!=3);

                    }
                }
                
            }
            

            
        }
    }
}