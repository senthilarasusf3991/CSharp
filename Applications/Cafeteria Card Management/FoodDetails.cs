namespace CafeteriaCardManagement
{
    public class FoodDetails
    {
        /// <summary>
        /// Belongs to class <see Cref ="FoodDetails"/> that stores the identity of each object
        /// </summary>
        
        private static int s_foodID=100;

        public string FoodID{get;}
        /// <summary>
        /// Belongs to class <see Cref ="FoodDetails"/> shows the FoodName
        /// </summary>
        /// <value></value>
        public string FoodName{get;set;}
        /// <summary>
        /// Belongs to class <see Cref ="FoodDetails"/> shows the Price of food
        /// </summary>
        /// <value></value>
        public double FoodPrice{get;set;}
        /// <summary>
        /// Belongs to class <see Cref ="FoodDetails"/> shows the Price of food Quantity Available
        /// </summary>
        /// <value></value>
        public int AvailableQuantity{get;set;}
        /// <summary>
        /// Belongs to the class <see Cref="FoodDetails"/> that initiates the property and methods of class
        /// </summary>
        /// <param name="foodName">It passes the food Name</param>
        /// <param name="foodPrice">It passes the food Price</param>
        /// <param name="availableQuantity">It passes the quantity available</param>
        public FoodDetails(string foodName,double foodPrice, int availableQuantity)
        {
            s_foodID++;
            FoodID="FID"+s_foodID;
            FoodName=foodName;
            FoodPrice=foodPrice;
            AvailableQuantity=availableQuantity;

        }
        public void ShowFoodDetails()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15}   |",FoodID,FoodName,FoodPrice,AvailableQuantity);
        }

    }
}