using System;
namespace MedicalStore
{
    public class Userdetails
    {
        private static int s_userID=1000;
        //Properties
        public string UserID{get;}
        public string UserName{get; set;}
        public int Age{get;set;}
        public string City {get;set;}
        public long PhoneNumber{get; set;}
        public double Balance{get;set;}

        public Userdetails(string userName, int age, string city, long phoneNumber, double balance)
        {
            s_userID++;
            UserID="UID"+s_userID;
            UserName=userName;
            Age=age;
            City=city;
            PhoneNumber=phoneNumber;
            Balance=balance;
        }
    }
}