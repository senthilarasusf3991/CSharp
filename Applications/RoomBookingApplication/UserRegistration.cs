using System;
namespace RoomBookingApplication
{
    public class UserRegistration:PersonalDetails,IWalletManager
    {
        private static double s_userID=1000;
        public string UserID{get;}
        private double _walletBalance = 0;
        public double WalletBalance{get{return _walletBalance;}}
        public UserRegistration(string name,long mobileNumber, long aadharNumber, string address, FoodType foodType, Gender gender,double walletBalance):base( name, mobileNumber,  aadharNumber,  address,  foodType,  gender)
        {
            s_userID++;
            UserID="SF"+s_userID;
            _walletBalance=walletBalance;
            Name=name;
            MobileNumber=mobileNumber;
            AadharNumeber=aadharNumber;
            Address=address;
            FoodType=foodType;
            Gender=gender;
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
        
        public void ShowUserRegistration()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} | {5,-15} | {6,-15} | {7,-15} |",UserID,Name,MobileNumber,AadharNumeber,Address,FoodType,Gender,WalletBalance);
        }

    }
}