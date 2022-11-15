using System;
namespace HierachiInheritence
{
    public class AccountDetails:StudentDetails
    {
        private static int s_accountID=100;
        public string AccountID{get;set;}
        public string AccountType{get; set;}
        public AccountDetails(string aID,string name, string fatherName, Gender holderGender, DateTime dob,Department studentDepartment,Year years,string accountType):base(aID,name,fatherName,holderGender,dob,studentDepartment,years)
        {
            s_accountID++;
            AccountID="Canara"+AccountID;
            AccountType=accountType;
        }
        public void StudentAccountInfo()
        {
            System.Console.WriteLine($"AccountNumber: {AccountID}");
            System.Console.WriteLine($"AccountType: {AccountType}");
            ShowDetails();
            ShowStudent();
            


        }
    }
}