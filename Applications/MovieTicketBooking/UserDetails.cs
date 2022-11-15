namespace MovieTicketBooking
{
    public class UserDetails:PersonalDetails,IWallet
    {
        private static int s_userID=1000;
        public string UserID{get;}
        public double WalletBalance{get;set;}
        public UserDetails(string name,int age,long phoneNumber,double walletBalance):base( name, age, phoneNumber)
        {
            s_userID++;
            UserID="UID"+s_userID;
            WalletBalance=walletBalance;
        }
   
        public void RechargeWallet(int amount)
        {
            WalletBalance=WalletBalance+amount;
        }

    }
}