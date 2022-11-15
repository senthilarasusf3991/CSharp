
using System;
using System.Collections.Generic;
namespace SingleInheritence2
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<AccountInfo> accountList=new List<AccountInfo>();
            AccountInfo account1=new AccountInfo("senthil","balu",9629254040,"senthil@gmail.com",new DateTime(2020,10,05),Gender.Male,"KotturpuramBranch","CNRB1001",20000);
            accountList.Add(account1);
            AccountInfo account2=new AccountInfo("priyan","ravi",9629574040,"priyan@gmail.com",new DateTime(2017,07,09),Gender.Male,"KotturpuramBranch","CNRB1001",30000);
            accountList.Add(account2);
            AccountInfo account3=new AccountInfo("mathi","mari",9829454040,"mathi@gmail.com",new DateTime(2019,08,05),Gender.Male,"AdayarBranch","CNRB1008",25000);
            accountList.Add(account3);
         
            foreach(AccountInfo account in accountList)
            {
                if(account.AccountNumber.Equals("AC1002"))
                {
                    System.Console.WriteLine("-----BEFORE UPDATE-----");
                    account.ShowAccountInfo();
                    System.Console.WriteLine("-----AFTER UPDATE-----");
                    account.ShowUpdateInfo("priyan","ravi",9842362998,"priyanravi@gmail.com",new DateTime(2017,07,09),Gender.Male,"KotturpuramBranch","CNRB1001",20000);
                    account.ShowAccountInfo();

                    account.WalletBalance();
                    account.Deposit(2000);

                    account.WalletBalance();
                    account.Withdraw(3000);

                    account.WalletBalance();

                    
                }

            }   
        }
    }
}