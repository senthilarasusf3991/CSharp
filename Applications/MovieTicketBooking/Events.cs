namespace MovieTicketBooking
{
    public delegate void EventManager();
    public partial class Operations
    {
        public static EventManager starter;
        public static event EventManager ticketBooking,ticketCancellation,bookingHistory,walletRecharge;
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
            ticketBooking=new EventManager(TicketBooking);
            ticketCancellation=new EventManager(TicketCancellation);
            bookingHistory=new EventManager(BookingHistory);
            walletRecharge=new EventManager(WalletRecharge);
        
        }
        
    }
}