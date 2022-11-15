using System;
namespace CafeteriaCardManagement
{
    public enum OrderStatus{Default, Initiated , Ordered, Cancelled}
    public class OrderDetails
    {
        /// <summary>
        /// Belongs to class <see Cref ="OrderDetails"/> that stores the identity of each object
        /// </summary>
        private static int s_orderID=1000;
        /// <summary>
        /// Belongs to class <see Cref ="OrderDetails"/> that stores the OrderID
        /// </summary>
        /// <value></value>
        public string OrderID{get;}
        /// <summary>
        /// It shows the identity of User Class
        /// </summary>
        /// <value></value>
        public string UserID{get;set;}
        /// <summary>
        /// It shows the Order Date 
        /// </summary>
        /// <value></value>
        public DateTime OrderDate{get;set;}
        /// <summary>
        /// Belongs to class <see Cref ="OrderDetails"/> that stores Totals Price
        /// </summary>
        /// <value></value>
        public double TotalPrice{get;set;}
        /// <summary>
        /// Belongs to class <see Cref ="OrderDetails"/> that OrderStatus
        /// </summary>
        /// <value></value>
        public OrderStatus OrderStatus{get;set;}
        /// <summary>
        /// Belongs to the class <see Cref="OrderDetails"/> that initiates the property and methods of class
        /// </summary>
        /// <param name="userID">It passes the User Identity</param>
        /// <param name="orderDate">It passes the Order Date</param>
        /// <param name="totalPrice">It passes the Total Price</param>
        /// <param name="orderStatus">It passes the OrderStatus</param>
        public OrderDetails(string userID, DateTime orderDate, double totalPrice, OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            UserID=userID;
            OrderDate=orderDate;
            TotalPrice=totalPrice;
            OrderStatus=orderStatus;

        }
        public void ShowOrderDetails()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} |",OrderID,UserID,OrderDate.ToString("dd/MM/yyyy"),TotalPrice,OrderStatus);
        }


    }
}