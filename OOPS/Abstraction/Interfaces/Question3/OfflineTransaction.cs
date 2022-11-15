using System;
namespace Question3
{
    public class OfflineTransaction:ITransaction
    {
        private static int s_transactionID=1000;
        public string TransactionID {get;set;}
        public int[] Purchase{get;set;}
        public DateTime DateOfPurchase{get;set;}
        public int TotalAmount { get; set; }
        public OfflineTransaction(int[] purchase,DateTime date)
        {
            s_transactionID++;
            TransactionID="TID"+s_transactionID;
            Purchase=purchase;
            DateOfPurchase=date;
        }
         public void CalculateAmount()
         {
            int totalAmount=0;
            foreach(int amount in Purchase)
            {
                totalAmount=totalAmount+amount;
            }
            TotalAmount=totalAmount;
         }
         public void DisplayBill()
         {
            System.Console.WriteLine($"Your total amount   :{TotalAmount}");
         }
    }
}