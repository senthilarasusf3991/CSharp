namespace MovieTicketBooking
{
    public interface IWallet
    {
        public double WalletBalance{get;set;}
        public void RechargeWallet(int amount);
  
    }
}