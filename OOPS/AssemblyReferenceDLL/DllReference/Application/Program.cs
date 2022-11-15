
using System;
using EBBill;
using System.Collections.Generic;

namespace EBBill
{
    class Program
    {
        static List<EBBillCalculation> ebList=new List<EBBillCalculation>();
        public static void Main(string[] args)
        {
            int option;
            do{
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
                    case 4:
                    {
                        System.Console.WriteLine("Invalid entry enter again");
                        break;
                    }
                }
            }while(option!=3);


            static void Registration()
            {
                System.Console.WriteLine("Enter your name: ");
                string name=Console.ReadLine();
                System.Console.WriteLine("Enter your number: ");
                long phoneNo=long.Parse(Console.ReadLine());
                System.Console.WriteLine("Enter your mail Id");
                string mailID=Console.ReadLine();
                System.Console.WriteLine("Enter the total units used: ");
                double unitsUsed=double.Parse(Console.ReadLine());
                
                
                EBBillCalculation details=new EBBillCalculation(name,phoneNo,mailID,unitsUsed);
                ebList.Add(details);
                System.Console.WriteLine("Your meter ID is"+details.MeterID);
                
            }
            static void Login()
            {
                int suboption;
                System.Console.WriteLine("Enter your meter ID: ");
                string meterID=Console.ReadLine();
                foreach(EBBillCalculation customer in ebList)
                {
                    if (meterID.Equals(customer.MeterID))
                    {
                        System.Console.WriteLine("User found");
                        do
                        {
                            System.Console.WriteLine("1.CalculateAmount 2.Exit");
                            suboption=int.Parse(Console.ReadLine());
                            switch(suboption)
                            {
                                case 1:
                                {
                                    System.Console.WriteLine(customer.Name);
                                    System.Console.WriteLine("Units used"+customer.UnitsUsed);
                                    System.Console.WriteLine("The total amount you need to pay is"+customer.CalculateAmount());
                                    break;

                                }
                                case 2:
                                {
                                    break;

                                }
                                default :
                                {
                                    System.Console.WriteLine("Invalid option enter the correct option");
                                    break;
                                }
                            }
                        }while(suboption!=2);
                    }
                }
            }


        }
    }
}
