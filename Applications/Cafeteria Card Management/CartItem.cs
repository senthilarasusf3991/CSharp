using System;
namespace CafeteriaCardManagement
{
    public class CartItem
    {
        /// <summary>
        ///  Belongs to class <see Cref ="CartItem"/> that stores the identity of each object
        /// </summary>
        private static int s_itemID=100;
        public string ItemID{get;}
        /// <summary>
        /// It shows the Identity of Order Class
        /// </summary>
        /// <value></value>
        public string OrderID{get;set;}
        /// <summary>
        /// It shows the Identity of Food Class
        /// </summary>
        /// <value></value>
        public string FoodID{get;set;}
        /// <summary>
        /// It shows the Order Price
        /// </summary>
        /// <value></value>
        public double OrderPrice{get;set;}
        /// <summary>
        /// Shows the Order Quantity
        /// </summary>
        /// <value></value>
        public int OrderQuantity{get;set;}
        /// <summary>
        /// Belongs to the class <see Cref="CartItem"/> that initiates the property and methods of class
        /// </summary>
        /// <param name="orderID">It passes the Order Identity</param>
        /// <param name="foodID">It passes the food Identity</param>
        /// <param name="orderPrice">Passes the Order Price</param>
        /// <param name="orderQuantity">Passes the Order Quantity</param>
        public CartItem(string orderID,string foodID,double orderPrice, int orderQuantity)
        {
            s_itemID++;
            ItemID="ITID"+s_itemID;
            OrderID=orderID;
            FoodID=foodID;
            OrderPrice=orderPrice;
            OrderQuantity=orderQuantity;
        }
        public void ShowCartItemDetails()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} |",ItemID,OrderID,FoodID,OrderPrice,OrderQuantity);
        }

    }
}