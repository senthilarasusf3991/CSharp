namespace OnlineGroceryStore
{
    public interface IBalance
    {
        public double WalletBalance{get;set;}
        public double WalletRecharge(double amount);
        
    }
}