using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        SavingAccount customer1=new SavingAccount(){Name="senthil",AccountType=AccountType.Savings,PanNumber="8883738453"};
        customer1.Deposit(4000);
        customer1.Withdraw(300);
        System.Console.WriteLine("Your saving account balance is "+customer1.BalanceCheck());
        RecurringDeposit customer2=new RecurringDeposit(){Name="balu",AccountType=AccountType.Savings,PanNumber="8883738453"};
        customer1.Deposit(40000);
        customer1.Withdraw(300);
        System.Console.WriteLine("Your saving RD balance is "+customer1.BalanceCheck());
    }
}