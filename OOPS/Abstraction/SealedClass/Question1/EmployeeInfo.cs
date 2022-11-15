using System;
namespace Question1
{


    public sealed class EmployeeInfo
    {
        private static int s_userID=1000;
        public string UserID { get; set; }
        public string PassWord { get; set; }
        public int KeyInfo=100;
        public EmployeeInfo(string Password)
        {
            s_userID++;
            UserID="UID"+s_userID;
            this.PassWord=PassWord;
        }
        public void UpdateInfo(string passWord)
        {
            PassWord=passWord;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"User ID is :{UserID}");
            System.Console.WriteLine($"Password is :{PassWord}");
        }
        
        
    }
}