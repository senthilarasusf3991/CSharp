namespace MetroCardManagement
{
    public class TicketFairDetails
    {
        private static int s_ticketID=100;
        public string TicketID{get;}
        public string FromLocation{get;set;}
        public string ToLocation{get;set;}
        public double TicketPrice{get;set;}
        public TicketFairDetails(string fromLocation, string toLocation,double ticketPrice)
        {
            s_ticketID++;
            TicketID="MR"+s_ticketID;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            TicketPrice=ticketPrice;
        }
        public void ShowTicketFairDetails()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15} |",TicketID,FromLocation,ToLocation,TicketPrice);
        }
    }
}