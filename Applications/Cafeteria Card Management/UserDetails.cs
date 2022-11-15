namespace CafeteriaCardManagement
{
    public class UserDetails:PersonalDetails,IBalance
    {
        /// <summary>
        /// Belongs to class <see Cref ="UserDetails"/> that stores the identity of each object
        /// </summary>
        private static int s_userID=1000;
        public string UserID{get;}
        /// <summary>
        /// Belongs to class <see Cref ="UserDetails"/> shows the Workstation number of user
        /// </summary>
        /// <value></value>
        public string WorkstationNumber{get;set;}
        
        private double _walletBalance = 0;
        /// <summary>
        /// P
        /// </summary>
        /// <value></value>
        public double WalletBalance{get{return _walletBalance;}}
        /// <summary>
        /// Belongs to the class <see Cref="User Details"/> that initiates the property and methods of class
        /// </summary>
        /// <param name="name">passes the name of the user</param>
        /// <param name="fatherName">passes the Father name of the user</param>
        /// <param name="gender">passes the gender of the user</param>
        /// <param name="mobileNumber"></param>
        /// <param name="mailID">passes the mailIdentity of user</param>
        /// <param name="workStationNumber">It gives the work satation number of User</param>
        /// <param name="walletBalance">Shows the Wallet Blalnce </param>
        /// <returns></returns>
       
        public UserDetails(string name,string fatherName, Gender gender,long mobileNumber,string mailID ,string workStationNumber,double walletBalance):base( name, fatherName,  gender, mobileNumber, mailID)
        {
            s_userID++;
            UserID="SF"+s_userID;
            WorkstationNumber=workStationNumber;
            _walletBalance=walletBalance;
        }
        public void WalletRecharge(double amount)
        {
            
            _walletBalance=_walletBalance+amount;
            System.Console.WriteLine($"Your current Balance is {WalletBalance}");
        }
        public void WalletDeduct(double amount)
        {
            _walletBalance -= amount;
        }
        public void ShowUserDetails()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5,-15} | {6,-15} | {7,-15} |",UserID,Name,FatherName,Gender,MobileNumber,MailID,WorkstationNumber,WalletBalance);
        }


    }
}