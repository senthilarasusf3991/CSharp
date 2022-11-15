using System;
namespace EcomApplication
{
    public class OrderDetails
    {
        private static int s_orderID=1000;
        public string OrderId{get;}
        public string CustomerID{get;}
        public string ProductID{get;}


        public double TotalPrice{get; set;}
        public DateTime PurchaseDate{get; set;}

        public int Quantity {get; set; }
        
        public string OrderStatus {get; set; }



        public OrderDetails( double totalPrice,string productID ,string customerID,DateTime purchaseDate,int quantity,string orderStatus)
        {
            s_orderID++;
            OrderId="OID"+s_orderID;
            CustomerID=customerID;
            ProductID=productID;
            TotalPrice=totalPrice;
            PurchaseDate=purchaseDate;
            Quantity=quantity;
            OrderStatus=orderStatus;

            
        }
    }
}