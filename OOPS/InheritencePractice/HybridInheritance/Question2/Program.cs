using System;
namespace Question2;
class Program{
    public static void Main(string[] args)
    {
        SavingAccount customer=new SavingAccount(){Name="senthl",Gender="Male",DOB=new DateTime(2001,04,04),phone="9620254088",VoterID="98556",AadharID="345678",PanNumber="45678965",BankName="CNRB",IFSC="98989"};
        customer.Deposit(400);
        Console.WriteLine($"Your balance is {customer.BalanceCheck()}");
        customer.Withdraw(230);
        Console.WriteLine($"Your balance is {customer.BalanceCheck()}");

    }
}