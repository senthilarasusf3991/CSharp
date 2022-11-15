namespace MovieTicketBooking
{
    public class MovieDetails
    {
        private static int s_movieID=500;
        public string MovieID{get;}
        public string MovieName{get;set;}
        public string MovieLanguage{get;set;}
        public MovieDetails(string movieName,string movieLanguage)
        {
            s_movieID++;
            MovieID="MID"+s_movieID;
            MovieName=movieName;
            MovieLanguage=movieLanguage;
        }
        public MovieDetails (string data)
        {
            string[] values=data.Split(',');
            s_movieID=int.Parse(values[0].Remove(0,3));
            MovieID=values[0];
            MovieName=values[1];
            MovieLanguage=values[2];
        }
        public void ShowMovieDetails()
        {
            System.Console.WriteLine("| {0,-15} | {1,-15}| {2,-15}|",MovieID,MovieName,MovieLanguage);
        }
    }
}