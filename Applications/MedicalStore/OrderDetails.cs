using System;
namespace MedicalStore
{
    public enum OrderStatus {Default, Purchased, Cancelled}
    public class OrderDetails
    {
        private static int s_orderID=2000;
        //Properties
        public string OrderID{get;}
        public string UserID{get;set;}
        public string MedicineID{get;set;}
        public int MedicineCount{get; set;}
        public double TotalPrice{get; set;}
        public DateTime OrderDate {get;set;}
        public OrderStatus HolderOrderStatus{get; set;}

        public OrderDetails(string userID,string medicineID,int medicineCount, double totalPrice, DateTime orderDate,OrderStatus holderOrderStatus)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            MedicineCount=medicineCount;
            MedicineID=medicineID;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            HolderOrderStatus=holderOrderStatus;
        }


    }
}