using System;
namespace SingleInheritence2
{
    public class AccountInfo:PersonalInfo
    {
        private static int s_accountNumber=1000;
        public string AccountNumber{get;}
        public string BranchName{get;set;}
        public string IFSCCode{get;set;}
        public double Balance{get;set;}
        public AccountInfo(string name, string fatherName, long phonenumber,string mail,DateTime dOB, Gender holderGender,string branchName, string iFSC, double balance):base( name,  fatherName,  phonenumber, mail, dOB,  holderGender)
        {
            s_accountNumber++;
            AccountNumber="AC"+s_accountNumber;

            BranchName=branchName;
            IFSCCode=iFSC;
            Balance=balance;

        }
        public void ShowUpdateInfo(string name, string fatherName, long phonenumber,string mail,DateTime dOB, Gender holderGender,string branchName, string iFSC, double balance)
        {
            Name=name;
            FatherName=fatherName;
            PhoneNumber=phonenumber;
            Mail=mail;
            DOB=dOB;
            HolderGender=holderGender;
            BranchName=branchName;
            IFSCCode=iFSC;
            Balance=balance;

        }
        public void ShowAccountInfo()
        {
            System.Console.WriteLine($"Name is                 :{Name}");
            System.Console.WriteLine($"FatherName is           :{FatherName}");
            System.Console.WriteLine($"HolderAccountNumber is  :{AccountNumber}");
            System.Console.WriteLine($"BranchName is           :{BranchName}");
            System.Console.WriteLine($"IFSCCode is             :{IFSCCode}");
            System.Console.WriteLine($"PhoneNumber is          :{PhoneNumber}");
            System.Console.WriteLine($"Mail is                 :{Mail}");
            System.Console.WriteLine($"DOB is                  :{DOB.ToShortDateString()}");
            System.Console.WriteLine($"HolderGender is         :{HolderGender}");
            System.Console.WriteLine($"Balance is              :{Balance}");
            

        }
        public void Deposit(double amount)
        {
            Balance=Balance+amount;
            System.Console.WriteLine("Successfully Deposited ");
            System.Console.WriteLine($"Your balance is {Balance}");
        }
        public void Withdraw(double amount)
        {
            Balance=Balance-amount;
            System.Console.WriteLine("Successfully Withdrawn");
            System.Console.WriteLine($"Your balance is {Balance}");
        }
        public void WalletBalance()
        {
            System.Console.WriteLine($"Your wallet balance is{Balance}");
        }



    }
}