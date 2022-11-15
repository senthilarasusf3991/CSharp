namespace CafeteriaCardManagement
{
    public interface IBalance
    {
        /// <summary>
        /// It stores the Wallet Balance
        /// </summary>
        /// <value></value>
         public double WalletBalance{get;}
         /// <summary>
         /// It increment the Value of the property Wallet Balance
         /// </summary>
         /// <param name="amount"></param>
         public void WalletRecharge(double amount);
    }
}