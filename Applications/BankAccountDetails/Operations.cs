using System;
using System.Collections.Generic;
namespace BankAccountDetails
{
    public static class Operations
    {
        private static List<CustomerDetails> customerLists = new List<CustomerDetails>();
        private static List<TransactionDetails> transactionLists = new List<TransactionDetails>();
        private static CustomerDetails currentLoggedInCustomer;
        public static void DefaultDatas()
        {
            CustomerDetails customer1 = new CustomerDetails("Ravi", "SB", Gender.Male, "Chennai", "3782783", DateTime.ParseExact("23/10/2000", "dd/MM/yyyy", null), "ravi@mail", 10000);
            CustomerDetails customer2 = new CustomerDetails("Baskaran", "SB", Gender.Male, "Theni", "3782783", DateTime.ParseExact("23/05/2000", "dd/MM/yyyy", null), "baskaran@mail", 20000);
            CustomerDetails customer3 = new CustomerDetails("Kumar", "CA", Gender.Male, "Trichy", "3243434", DateTime.ParseExact("10/05/2000", "dd/MM/yyyy", null), "kumar@mail", 50000);
            customerLists.Add(customer1);
            customerLists.Add(customer2);
            customerLists.Add(customer3);

            TransactionDetails transaction1 = new TransactionDetails(10001, 10001, "SB", TransactionType.Deposit, DateTime.Now, 10000);
            TransactionDetails transaction2 = new TransactionDetails(10001, 10002, "SB", TransactionType.Transfer, DateTime.Now, 5000);
            TransactionDetails transaction3 = new TransactionDetails(10002, 10003, "CA", TransactionType.Transfer, DateTime.Now, 6000);
            TransactionDetails transaction4 = new TransactionDetails(10002, 10002, "SB", TransactionType.Withdraw, DateTime.Now, 1000);
            transactionLists.Add(transaction1);
            transactionLists.Add(transaction2);
            transactionLists.Add(transaction3);
            transactionLists.Add(transaction4);


        }
        public static void MainMenu()
        {
            int choice;
            do
            {
                System.Console.WriteLine("WELCOME");
                System.Console.WriteLine("1. Account Creation:");
                System.Console.WriteLine("2. Login:");
                System.Console.WriteLine("3. Exit:");
                System.Console.WriteLine("Enter your Option:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
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
                        break;
                    default:
                        {
                            System.Console.WriteLine("Invalid Choice..");
                            break;
                        }
                }
            } while (choice != 3);
        }
        private static void Registration()
        {
            Gender holderGender=Gender.Default;
            
            string userName,accountType, address, mailId, mobileNumber;
            double accountBalance;
            DateTime dob;
            
            System.Console.Write("Enter Your Name: ");
            userName = Console.ReadLine();
            System.Console.Write("Enter Your Account Type SB, CA, RD, FD: ");
            accountType = Console.ReadLine();
            
            
            System.Console.WriteLine("Enter the gender  Male, Female, Transgender: ");
            while(!Enum.TryParse<Gender> (Console.ReadLine(),true,out holderGender) || !(((int)holderGender>0) && ((int)holderGender<4)))
                System.Console.WriteLine("Invalid entry Enter again");
            System.Console.Write("Enter your address: ");
            address = Console.ReadLine();
            System.Console.Write("Enter Mobile number: ");
            mobileNumber = Console.ReadLine();
            System.Console.Write("Enter your mail id: ");
            mailId = Console.ReadLine().ToLower();
            System.Console.Write("Enter Date of birth:");
            dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            System.Console.Write("Enter account balance:");
            accountBalance = double.Parse(Console.ReadLine());

            CustomerDetails currentCustomer = new CustomerDetails(userName, accountType, holderGender, address, mobileNumber, dob, mailId, accountBalance);

            customerLists.Add(currentCustomer);
            
            System.Console.WriteLine("Your Account Number is:" + currentCustomer.AccountNumber);
            
        }
        private static void Login()
        {
            int flag = 1;
            do
            {
                System.Console.Write("Enter Account Number: ");
                int accountNumber = int.Parse(Console.ReadLine());
                foreach (CustomerDetails customer in customerLists)
                {
                    if (accountNumber == customer.AccountNumber)
                    {
                        currentLoggedInCustomer = customer;
                        LoginSubMenu();
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                    }
                }
            } while (flag == 0);
        }
        private static void LoginSubMenu()
        {
            int choice;
            do
            {
                
                System.Console.WriteLine("Choose from Below Options...");
                System.Console.WriteLine("1. Show Account Details");
                System.Console.WriteLine("2. Deposit");
                System.Console.WriteLine("3. WithDraw");
                System.Console.WriteLine("4. Show Balance");
                System.Console.WriteLine("5. Transfer Amount");
                System.Console.WriteLine("6. Show Transaction History");
                System.Console.WriteLine("7. Exit");
                System.Console.WriteLine("Enter your Option:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            ShowAccountDetails();
                            break;
                        }
                    case 2:
                        {
                            Deposit();
                            break;
                        }
                    case 3:
                        {
                            WithDraw();
                            break;
                        }
                    case 4:
                        {
                            ShowAccountBalance();
                            break;
                        }
                    case 5:
                        {
                            TransferAmount();
                            break;
                        }
                    case 6:
                        {
                            ShowTransactionHistory();
                            break;
                        }
                    case 7:
                        {
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Invalid Choice..");
                            break;
                        }
                }
            } while (choice != 7);
        }
        private static void ShowAccountDetails()
        {
            foreach (CustomerDetails customer in customerLists)
            {
                if (currentLoggedInCustomer.AccountNumber == customer.AccountNumber)
                {
                    System.Console.WriteLine("Account Number: " + customer.AccountNumber);
                    System.Console.WriteLine("Account Holder Name: " + customer.UserName);
                    System.Console.WriteLine("Gender: " + customer.HolderGender);
                    System.Console.WriteLine("Mobile Number: " + customer.MobileNumber);
                    System.Console.WriteLine("Account Type: " + customer.AccountType);
                    System.Console.WriteLine("Email ID: " + customer.MailId);
                    System.Console.WriteLine("Date of Birth: " + customer.DOB.ToShortDateString());
                    System.Console.WriteLine("Address: " + customer.Address);
                }
            }
        }
        private static void Deposit()
        {
            System.Console.Write("Enter Amount to Deposit: ");
            double depositAmount = double.Parse(Console.ReadLine());
            foreach (CustomerDetails customer in customerLists)
            {
                if (currentLoggedInCustomer.AccountNumber == customer.AccountNumber)
                {
                    currentLoggedInCustomer.AccountBalance += depositAmount;
                    TransactionDetails currentTransaction = new TransactionDetails(currentLoggedInCustomer.AccountNumber, currentLoggedInCustomer.AccountNumber, currentLoggedInCustomer.AccountType, TransactionType.Deposit, DateTime.Now, depositAmount);
                    transactionLists.Add(currentTransaction);
                    System.Console.WriteLine("Amount deposited successfully");
                }
            }
        }
        private static void WithDraw()
        {
            System.Console.Write("Enter Amount to Withdraw: ");
            double withdrawalAmount = double.Parse(Console.ReadLine());
            foreach (CustomerDetails customer in customerLists)
            {
                if (currentLoggedInCustomer.AccountNumber == customer.AccountNumber)
                {
                    if (currentLoggedInCustomer.AccountBalance < withdrawalAmount)
                    {
                        System.Console.WriteLine("Insufficient Balance ");
                    }
                    else
                    {
                        currentLoggedInCustomer.AccountBalance -= withdrawalAmount;
                        TransactionDetails currentTransaction = new TransactionDetails(currentLoggedInCustomer.AccountNumber, currentLoggedInCustomer.AccountNumber, currentLoggedInCustomer.AccountType, TransactionType.Withdraw, DateTime.Now, withdrawalAmount);
                        transactionLists.Add(currentTransaction);
                        System.Console.WriteLine("Amount Withdrawn successfully");
                    }
                }
            }
        }
        private static void TransferAmount()
        {
            System.Console.WriteLine("Enter Receiver's Account Number: ");
            int receiverAccountNumber = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Receiver's Account Type SB, CA, RD, FD: ");
            string receiverAccountType = Console.ReadLine().ToUpper();
            foreach (CustomerDetails customer in customerLists)
            {
                if (receiverAccountNumber == customer.AccountNumber && receiverAccountType == customer.AccountType)
                {
                    System.Console.WriteLine("Enter the Amount to Transfer: ");
                    double transferAmount = double.Parse(Console.ReadLine());
                    if (currentLoggedInCustomer.AccountBalance < transferAmount)
                    {
                        System.Console.WriteLine("Insufficient Fund to Transfer ");
                    }
                    else
                    {
                        customer.AccountBalance += transferAmount;
                        currentLoggedInCustomer.AccountBalance -= transferAmount;
                        TransactionDetails currentTransaction = new TransactionDetails(currentLoggedInCustomer.AccountNumber, customer.AccountNumber, customer.AccountType, TransactionType.Transfer, DateTime.Now, transferAmount);
                        transactionLists.Add(currentTransaction);
                        System.Console.WriteLine("Amount Transfered Successfully");
                    }
                }
            }
        }
        private static void ShowTransactionHistory()
        {

            foreach (TransactionDetails transaction in transactionLists)
            {
                if (transaction.FromAccount == currentLoggedInCustomer.AccountNumber || transaction.ToAccount == currentLoggedInCustomer.AccountNumber)
                {
                    
                    
                    System.Console.WriteLine("Transaction ID: " + transaction.TransactionId);
                    System.Console.WriteLine("From: " + transaction.FromAccount);
                    System.Console.WriteLine("To: " + transaction.ToAccount);
                    System.Console.WriteLine("Receiver's Account Type: " + transaction.AccountType);
                    System.Console.WriteLine("Transaction Type: " + transaction.TransactionType);
                    System.Console.WriteLine("Transaction Date: " + transaction.TransactionDate);
                    System.Console.WriteLine("Total Transaction Amount: " + transaction.TransactionAmount);
                    Console.ResetColor();
                    

                }
            }
        }
        private static void ShowAccountBalance()
        {
            System.Console.WriteLine("Your Current Balance is: " + currentLoggedInCustomer.AccountBalance);
        }
    }
}