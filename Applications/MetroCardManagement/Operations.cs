using System;
using System.Collections.Generic;
namespace MetroCardManagement
{
    public class Operations
    {
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<TravelDetails> travelList = new List<TravelDetails>();
        public static List<TicketFairDetails> ticketFairList=new List<TicketFairDetails>();
        public static UserDetails CurrentUser;

        public static void MainMenu()
        {
            int option;
            System.Console.WriteLine("Welcome to Mainmenu");
            do
            {

            
                System.Console.WriteLine("1.User Registration 2.Login 3.Exit");
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
                        System.Console.WriteLine("exit");
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("invalid choice");
                        break;
                    }
                }

            }while(option!=3);
        }
        private static void Registration()
        {
            bool temp;
            long phoneNumber;
            double balance;
            System.Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();
            System.Console.WriteLine("Enter Your mobile number: ");
            temp=long.TryParse(Console.ReadLine(),out phoneNumber);
            while(!temp)
            {
                System.Console.WriteLine("invalid input enter number in correct format: ");
                temp=long.TryParse(Console.ReadLine(),out phoneNumber);
            }
            System.Console.WriteLine("Enter your wallet balance: ");
            temp=double.TryParse(Console.ReadLine(),out balance);
            while (!temp)
            {
                System.Console.WriteLine("Invalid Input enter in correct format");
                System.Console.WriteLine("Enter Your WalletBalance: ");
                temp=double.TryParse(Console.ReadLine(),out balance);
            }

            UserDetails user=new UserDetails(name,phoneNumber,balance);
            userList.Add(user);
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine($"Your registration is Succussfull Your ID is {user.CardNumber}");
            Console.ResetColor();

            
        }
        private static void Login()
        {
            System.Console.WriteLine("Enter Your Login ID: ");
            string CardNumber=Console.ReadLine().ToUpper();
            bool flag=true;
            foreach(UserDetails user in userList)
            {
                if(CardNumber.Equals(user.CardNumber))
                {
                    flag=false;
                    CurrentUser=user;
                    System.Console.WriteLine("CardNumber found");
                    SubMenu();

                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid CardNumber Enter the correct number");
            }
            

        }
        private static void SubMenu()
        {
                
            int subOption;
            do{
                System.Console.WriteLine("1.BalanceCheck");
                System.Console.WriteLine("2.Recharge");
                System.Console.WriteLine("3.ViewTravelHistory");
                System.Console.WriteLine("4.Travel");
                System.Console.WriteLine("5.Go To MainMenu");
                System.Console.WriteLine("Enter the option");
                subOption=int.Parse(Console.ReadLine());
                switch(subOption)
                
                {
                    case 1:
                    {
                        BalanceCheck();
                        break;
                    }
                    case 2:
                    {
                        Recharge();
                        break;
                    }
                    case 3:
                    {
                        TravelHistory();
                        break;
                    }
                    case 4:
                    {
                        Travel();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("You are Seeing the Main menu");
                        break;
                    }
                    default :
                    {
                        System.Console.WriteLine("Invalid Option enter the correct choice");
                        break;
                    }
                }


            }while(subOption!=5);
        }
        private static void BalanceCheck()
        {
            System.Console.WriteLine($"Your Current Balance is {CurrentUser.Balance}");
        }
        private static void Recharge()
        {
            double amount;
            System.Console.WriteLine("Enter the Amount You want to Recharge: ");
            amount=double.Parse(Console.ReadLine());
            CurrentUser.Balance+=amount;
            System.Console.WriteLine("Recharged Successfully");
            System.Console.WriteLine($"Your Balance after Recharge is {CurrentUser.Balance}");
        }
        public static void TravelHistory()
        {
            bool flag=true;
            System.Console.WriteLine("|-----------------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("|    TravelID    |  CardNumber    |  FromLocation    |   ToLocation      |     Date       |    TravelCost   |");

            System.Console.WriteLine("|-----------------------------------------------------------------------------------------------------------|");
            foreach(TravelDetails travel in travelList)
            {
                if(CurrentUser.CardNumber.Equals(travel.CardNumber))
                {
                    flag=false;
                    travel.ShowTravelHistory();
                    System.Console.WriteLine("|-----------------------------------------------------------------------------------------------------------|");
                }
            }
            if(flag)
            {
                System.Console.WriteLine("No travel History found");
            }
        }
        private static void Travel()
        {
            bool flag=true;
            System.Console.WriteLine("|------------------------------------------------------------------------|");
            System.Console.WriteLine("|    TicketID    |  FromLocation    |   ToLocation    |       Fair       |");

            System.Console.WriteLine("|------------------------------------------------------------------------|");
            foreach(TicketFairDetails ticket in ticketFairList)
            {
                ticket.ShowTicketFairDetails();
                System.Console.WriteLine("|------------------------------------------------------------------------|");

            }
            System.Console.WriteLine("Enter the TicketID to travel: ");
            string ticketID=Console.ReadLine().ToUpper();
            foreach(TicketFairDetails ticket in ticketFairList)
            {
                if(ticketID.Equals(ticket.TicketID))
                {
                    flag=false;
                    if(CurrentUser.Balance>=ticket.TicketPrice)
                    {
                        CurrentUser.Balance-=ticket.TicketPrice;
                        TravelDetails newTravel=new TravelDetails(CurrentUser.CardNumber,ticket.FromLocation,ticket.ToLocation,DateTime.Today,ticket.TicketPrice);
                        travelList.Add(newTravel);
                        System.Console.WriteLine($"Ticket Booked Successfully Your Ticket ID is{newTravel.TravelID}");

                    }
                    else
                    {
                        System.Console.WriteLine("Amount Insufficient Recharge immedietly to Take Travel");
                        Recharge();
                    }
                }
                if(flag)
                {
                    System.Console.WriteLine("Invalid Ticket ID");
                }
            }
            
        }


        public static void DefaultDetails()
        {
            UserDetails user1=new UserDetails("Ravi",98488,1000);
            UserDetails user2=new UserDetails("Baskaran",98488,1000);
            userList.Add(user1);
            userList.Add(user2);

            TravelDetails travel1=new TravelDetails("CMRL101","Airport","Egmore",new DateTime(2022,10,10),55);
            TravelDetails travel2=new TravelDetails("CMRL101","Egmore","Koyambedu",new DateTime(2022,10,10),32);
            TravelDetails travel3=new TravelDetails("CMRL102","Alandur","Koyambedu",new DateTime(2022,11,10),25);
            TravelDetails travel4=new TravelDetails("CMRL102","Egmore","Thirumangalam",new DateTime(2022,11,10),25);
            travelList.Add(travel1);
            travelList.Add(travel2);
            travelList.Add(travel3);
            travelList.Add(travel4);

            TicketFairDetails ticket1=new TicketFairDetails("Airport","Egmore",55);
            TicketFairDetails ticket2=new TicketFairDetails("Airport","Koyambedu",25);
            TicketFairDetails ticket3=new TicketFairDetails("Alandur","Koyambedu",25);
            TicketFairDetails ticket4=new TicketFairDetails("Koyambedu","Egmore",32);
            TicketFairDetails ticket5=new TicketFairDetails("Vadapalani","Egmore",45);
            TicketFairDetails ticket6=new TicketFairDetails("Arumbakkam","Egmore",25);
            TicketFairDetails ticket7=new TicketFairDetails("Vadapalani","Koyambedu",25);
            TicketFairDetails ticket8=new TicketFairDetails("Arumbakkam","Koyambedu",16);
            ticketFairList.Add(ticket1);
            ticketFairList.Add(ticket2);
            ticketFairList.Add(ticket3);
            ticketFairList.Add(ticket4);
            ticketFairList.Add(ticket5);
            ticketFairList.Add(ticket6);
            ticketFairList.Add(ticket7);
            ticketFairList.Add(ticket8);

        

        }
        
    }
}