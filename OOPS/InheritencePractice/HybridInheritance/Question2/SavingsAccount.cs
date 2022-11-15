namespace Question2
{
    public enum AccountType{Savings,Balance}
    public class SavingAccount:IDInfo,ICalculate,BankInfo
    {
         public string BankName { get; set; }
        public string Branch { get; set; }
        
        public string IFSC{get;set;}
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public int  Balance { get; set; }
        
        public void Deposit(int amount)
        {
            Balance=Balance+amount;
        }
        public void Withdraw(int amount)
        {
            Balance=Balance-amount;
        }
        public int BalanceCheck()
        {
            return Balance;
        }
    }
}