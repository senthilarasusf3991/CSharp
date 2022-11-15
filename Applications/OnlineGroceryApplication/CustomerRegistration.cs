using System;
namespace OnlineGroceryStore
{
    public class CustomerRegistration:PersonalDetails,IBalance
    {
        private static int s_customerID=3000;
        public string CustomerID{get;set;}
        public double WalletBalance{get;set;}
        
        
        
        public CustomerRegistration(string name, string fatherName, Gender gender, long mobileNumber,DateTime dOB,string mailID,double walletBalance):base( name,  fatherName,  gender,  mobileNumber, dOB, mailID)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            MobileNumber=mobileNumber;
            DOB=dOB;
            MailID=mailID;
            WalletBalance=walletBalance;
            
        }
        public double WalletRecharge(double amount)
        {
            WalletBalance=WalletBalance+amount;
            return WalletBalance;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("| {0,-12} | {1,-15} | {2,-12} | {3,-14} | {4,-8} | {5,-12} | {6,-12} | {7,-20} |",CustomerID,WalletBalance,Name,FatherName,Gender,MobileNumber,DOB.ToString("dd/MM/yyyy"),MailID);

        }
        
    }
}