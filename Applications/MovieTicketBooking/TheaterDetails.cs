namespace MovieTicketBooking
{
    public class TheaterDetails
    {
        private static int s_theaterID=300;
        public string TheaterID{get;}
        public string TheaterName{get;set;}
        public string TheaterLocation{get;set;}
        public TheaterDetails(string theaterName,string theaterLocation)
        {
            s_theaterID++;
            TheaterID="TID"+s_theaterID;
            TheaterName=theaterName;
            TheaterLocation=theaterLocation;
        }
        public TheaterDetails(string data)
        {
            string[] values=data.Split(',');
            s_theaterID=int.Parse(values[0].Remove(0,3));
            TheaterID=values[0];
            TheaterName=values[1];
            TheaterLocation=values[2];
        }
        public void ShowTheaterDeatailas()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15}| {2,-15}|",TheaterID,TheaterName,TheaterLocation);
        }
    }
}