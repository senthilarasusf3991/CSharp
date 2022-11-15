using System;
using System.Collections.Generic;
namespace BankApplication
{
    class Program
    {
        static List<ApplicationDetails> customerList = new List<ApplicationDetails>();
        public static void Main (string[] args)
        {
            int option;
            do
            {
            
                System.Console.WriteLine("1.Registration 2.Login 3.Exit ");
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
                        System.Console.WriteLine("Invalid choice Enter again: ");
                        break;
                    }
                    
                }

            }while(option!=3);

            static void Registration()
            {
                Gender holderGender=Gender.Default;
                Account accountType=Account.Default;
                System.Console.WriteLine("Enter your name: ");
                string name=Console.ReadLine();
                System.Console.WriteLine("Enter the gender  Male, Female, Transgender: ");
                while(!Enum.TryParse<Gender> (Console.ReadLine(),true,out holderGender) || !(((int)holderGender>0) && ((int)holderGender<4)))
                    System.Console.WriteLine("Invalid entry Enter again");
                System.Console.WriteLine("Enter the Account Type  Current, Savings: ");
                while(!Enum.TryParse<Account>(Console.ReadLine(),true,out accountType) || (!((int)accountType>0) && ((int)accountType<3)))
                    System.Console.WriteLine("Invalid entry Enter again");
                System.Console.WriteLine("Enter your phone no: ");
                long phoneNo=long.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter mailID");
                string mailID=Console.ReadLine();
                
                System.Console.WriteLine("Enter your Date of birth dd/MM/yyyy : ");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

                ApplicationDetails holder = new ApplicationDetails(name, holderGender , accountType, phoneNo,mailID,dob);
                System.Console.WriteLine($"You Login ID is: {holder.CustomerID}");
                customerList.Add(holder);



            }
            static void Login()
            {
                System.Console.WriteLine("Enter your Login ID: ");
                string check = Console.ReadLine();
                foreach(ApplicationDetails details in customerList)
                {
                    if (check.Equals(details.CustomerID))
                    {
                        System.Console.WriteLine("user id found");
                        int loginOption;
                        do
                        {
                            System.Console.WriteLine("1.Deposit 2.Withdraw 3.Balancecheck 4.Exit");
                            loginOption=int.Parse(Console.ReadLine());
                            switch(loginOption)
                            {
                                case 1:
                                {
                                    System.Console.WriteLine("How much do you want to deposit: ");
                                    double amount=double.Parse(Console.ReadLine());
                                    details.Deposit(amount);
                                    
                                    break;
                                }
                                case 2:
                                {
                                    System.Console.WriteLine("How much do you want to Withdraw: ");
                                    double amount=double.Parse(Console.ReadLine());
                                    bool flag = details.Withdraw(amount);
                                    if(flag)
                                        System.Console.WriteLine("successfully withdrawn...");
                                    else
                                        System.Console.WriteLine("Insufficient balance...");
                                    
                                    break;   
                                }
                                case 3:
                                {
                                    System.Console.WriteLine("Your balance is "+details.Balance);
            
                                    break;
                                }
                                case 4:
                                {
                                    break;
                                }
                                default:
                                {
                                    System.Console.WriteLine("invalid choice enter again");
                                    break;
                                }

                            }
                        }while(loginOption!=4);

                    }
                    
                }

            }



        }
    }
}