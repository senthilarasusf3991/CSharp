using System;
namespace BankAccountDetails;
public enum TransactionType { Default, Deposit, Withdraw, Transfer };
    public class TransactionDetails
    {

    
    private static int _transactionId = 5000;

    
    public string TransactionId { get; }
    public int FromAccount { get; set; }
    public int ToAccount { get; set; }
    public string AccountType { get; set; }
    public DateTime TransactionDate { get; set; }
    public TransactionType TransactionType { get; set; }
    public double TransactionAmount { get; set; }

   
    public TransactionDetails(int fromAccount, int toAccount, string accountType , TransactionType transactionType,  DateTime transactionDate ,double transactionAmount)
    {
        _transactionId++;
        TransactionId = "TID" + _transactionId;
        FromAccount = fromAccount;
        ToAccount = toAccount;
        AccountType = accountType;
        TransactionType = transactionType;
        TransactionDate = transactionDate;
        TransactionAmount = transactionAmount;
    }

    
}