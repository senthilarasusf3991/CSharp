namespace MetroCardManagement
{
    public class UserDetails
    {
        public static int s_cardNumeber=100;
        public string CardNumber{get;}
        public string UserName{get;set;}
        public long PhoneNumber{get;set;}
        public double Balance{get;set;}
        public UserDetails(string userName,long phoneNumber,double balance)
        {
            s_cardNumeber++;
            CardNumber="CMRL"+s_cardNumeber;
            UserName=userName;
            PhoneNumber=phoneNumber;
            Balance=balance;
        }
        public void ShowUserDetails()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} |",UserName,PhoneNumber,Balance);
        }
    }
}