using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        OnlineTicket online=new OnlineTicket("Rohini",150,TicketType.Online,10);
        OfflineTicket offline=new OfflineTicket("Rohini",150,TicketType.Offline,10);
        System.Console.WriteLine("......Book Ticket Online ........");
        online.BookTicket();
        online.ShowTicket();
        System.Console.WriteLine("......Book Ticket Offline .........");
        online.BookTicket();
        online.ShowTicket();
    }
}