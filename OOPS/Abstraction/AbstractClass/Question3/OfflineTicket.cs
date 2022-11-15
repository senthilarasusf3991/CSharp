namespace Question3
{
    public class OfflineTicket:Ticket
    {
        public override TicketType TicketType { get ;set; }
        public override int SeatNumber{get;set;}
        public OfflineTicket(string theatername,int ticketPrice,TicketType ticketType,int seatNumber)
        {  
            TheaterName=theatername;
            TicketPrice=ticketPrice;
            TicketType=ticketType;
            SeatNumber=seatNumber;
        }
        public override void BookTicket()
        {
            System.Console.WriteLine("....TicketBooked Successfully....");
        }
        public override void ShowTicket()
        {
            System.Console.WriteLine($"Theatre name is   :{TheaterName}");
            System.Console.WriteLine($"TicketPrice is     :{TicketPrice}");
            System.Console.WriteLine($"TicketID is       :{TicketID}");
            System.Console.WriteLine($"TicketType is     :{TicketType}");
            System.Console.WriteLine($"SeatNumber is     :{SeatNumber}");
        }
    }
}