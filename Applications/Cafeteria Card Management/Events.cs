namespace CafeteriaCardManagement
{
    public delegate void EventManager();
    public partial class Operations
    {
        public static EventManager starter;
        public static event EventManager showMyProfile,foodOrder,cancelOrder,orderHistory,walletRecharge;
        public static void Starter()
        {
            Subscribe();
            starter();
        }
        public static void Subscribe()
        {
            starter+=new EventManager(Files.Create);
            starter+=new EventManager(Files.Read);
            starter+=new EventManager(MainMenu);
            starter+=new EventManager(Files.Write);
            showMyProfile=new EventManager(ShowMyProfile);
            foodOrder=new EventManager(FoodOrder);
            cancelOrder=new EventManager(CancelOrder);
            orderHistory=new EventManager(OrderHistory);
            
        
        }
        
    }
}