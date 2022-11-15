namespace MovieTicketBooking
{
    public class ScreeningDetails
    {
        public string MovieID{get;set;}
        public string TheaterID{get;set;}
        public int NoOfSeatsAvailable{get;set;}
        public double TicketPrice{get;set;}

        public ScreeningDetails(string movieID, string theaterID,int noOfSeatsAvailable,double ticketPrice)
        {
            MovieID=movieID;
            TheaterID=theaterID;
            NoOfSeatsAvailable=noOfSeatsAvailable;
            TicketPrice=ticketPrice;
        }
        public ScreeningDetails (string data)
        {
            string[] values=data.Split(',');
            MovieID=values[0];
            TheaterID=values[1];
            NoOfSeatsAvailable=int.Parse(values[2]);
            TicketPrice=double.Parse(values[3]);
        }
    }
}