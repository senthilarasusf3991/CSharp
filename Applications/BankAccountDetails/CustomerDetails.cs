using System;
namespace BankAccountDetails;
public enum Gender {Default, Male, Female, Transgender}

public class CustomerDetails
{
    
    private static int s_accountNumber = 10000;

     
    public int AccountNumber { get; }
    public string UserName { get; set; }
    public  Gender HolderGender{ get; set; }
    public string AccountType  { get; set; }
    public DateTime DOB { get; set; }
    public string Address { get; set; }
    public string MobileNumber { get; set; }
    public string MailId { get; set; }
    public double AccountBalance { get; set; }

    // Constructor
    public CustomerDetails( string userName, string accountType , Gender gender , string address, string mobileNumber, DateTime dob ,string mailId, double accountBalance)
    {
        s_accountNumber++;
        AccountNumber = s_accountNumber;
        UserName = userName;
        AccountType = accountType;
        MobileNumber = mobileNumber;
        MailId = mailId;
        HolderGender = gender;
        Address = address;
        DOB = dob;
        AccountBalance = accountBalance;
    }

}
