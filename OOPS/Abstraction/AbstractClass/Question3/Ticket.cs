namespace Question3
{

    public enum TicketType{Default,Online,Offline}
    public abstract class Ticket
    {
        private static int s_ticketID=100;
        public string TicketID{get{s_ticketID++;return "TID"+s_ticketID;}}
        public string TheaterName { get; set; }
        public int TicketPrice { get; set; }
        public abstract TicketType  TicketType { get; set; }
        public abstract int SeatNumber { get; set; }
        public abstract void BookTicket();
        public abstract void ShowTicket();       
    }
}