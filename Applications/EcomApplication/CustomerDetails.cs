namespace EcomApplication
{
    public class CustomerDetails
    {
        private static int s_customerID=1000;
        public string CustomerID{get;}

        public string Name{get; set; }

        public string City {get; set; }

        public long MobileNum{get; set; }

        public double WalletBalance {get; set; }

        public string EmailID {get; set; }

        public CustomerDetails(string name,string city,long mobileNum ,double walletBalance,string emailID)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;

            Name=name;
            City=city;
            MobileNum=mobileNum;
            WalletBalance=walletBalance;
            EmailID=emailID;
        }
        public double WalletRecharge (double amount)
        {
            WalletBalance=WalletBalance+amount;
            return WalletBalance;
        }
    }
}