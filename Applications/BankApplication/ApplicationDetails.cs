using System;



namespace BankApplication
{
    public enum Gender {Default, Male, Female, Transgender}
    public enum Account {Default, Current, Savings}
    public class ApplicationDetails
    {
        private static int s_customerID=1000;
        private static double s_balance=0;
        public string CustomerID {get; }
        public string Balance {get; set;}
        public string Name { get; set; }
        public Gender HolderGender {get; set;}
        public Account AccountType{get; set;}
        public long PhoneNo{get; set;}
        public string MailID{get; set;}
        public DateTime DOB {get; set;}

        
        
        
        
        

        public ApplicationDetails(string name, Gender gender ,Account accountType , long phoneNo, string mailID ,DateTime dob)
        {

         s_customerID++;
         CustomerID="HDFC"+s_customerID;
         Name = name;
         Balance = "Rs. " + s_balance;
         HolderGender = gender;
         AccountType=accountType;
         PhoneNo=phoneNo;
         MailID=mailID;
         DOB=dob;
         
        }

        public string Deposit(double amount)
        {
            s_balance=s_balance+amount;
            Balance="Rs. "+s_balance;
            return Balance;
        }
        public bool Withdraw(double amount)
        {
            if(s_balance>amount)
            {
                s_balance=s_balance-amount;
                Balance="Rs. "+s_balance;
                return true;
            }
            else
            {
                return false; 
            }

        }
        

        
        
    }
}