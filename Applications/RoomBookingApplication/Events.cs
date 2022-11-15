namespace RoomBookingApplication
{
    public delegate void EventManager();
    public partial class Operations
    {
        public static EventManager starter;
        public static event EventManager viewCustomerProfile,bookRoom,cancelBooking,bookingHistory;
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
            viewCustomerProfile=new EventManager(ViewCustomerProfile);
            bookRoom=new EventManager(BookRoom);
            cancelBooking=new EventManager(CancelBooking);
            bookingHistory=new EventManager(BookingHistory);
        
        }
        
    }
}