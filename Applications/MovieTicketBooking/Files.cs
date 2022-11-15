using System.IO;
namespace MovieTicketBooking
{
    public class Files
    {
        public static void  Create()
        {
            if(!Directory.Exists("MovieTicketBooking"))
            {
                System.Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("MovieTicketBooking");
            }
            else{
                System.Console.WriteLine("Folder exist");
            }
            if(!File.Exists("MovieTicketBooking/BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("MovieTicketBooking/BookingDetails.csv");
                file.Close();
            }
            else
            {
                System.Console.WriteLine("File already Exist");
            }
            if(!File.Exists("MovieTicketBooking/MovieDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("MovieTicketBooking/MovieDetails.csv");
                file.Close();
            }
            else
            {
                System.Console.WriteLine("File already exist");
            }
            if(!File.Exists("MovieTicketBooking/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                var file=File.Create("MovieTicketBooking/ScreeningDetails.csv");
                file.Close();
            }
            else
            {
                System.Console.WriteLine("File already exist");
            }
            if(!File.Exists("MovieTicketBooking/TheaterDetails.csv"))
            {
                System.Console.WriteLine("Creating file");
                var file=File.Create("MovieTicketBooking/TheaterDetails.csv");
                file.Close();
            }
            else
            {
                System.Console.WriteLine("File already exist");
            }
            if(!File.Exists("MovieTicketBooking/UserDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                var file=File.Create("MovieTicketBooking/UserDetails.csv");
                file.Close();
            }
            else{
                System.Console.WriteLine("File already exist");
            }
        }
        public static void Write()
        {
            string[] bookingDetails=new string[Operations.bookingList.Count];
            for(int i=0;i<Operations.bookingList.Count;i++)
            {
                //BookingID,UserID,MovieID,TheaterID,SeatCount,TotalAmount,BookingStatus 
                bookingDetails[i]=Operations.bookingList[i].BookingID+","+Operations.bookingList[i].UserID+","+Operations.bookingList[i].MovieID+","+Operations.bookingList[i].TheaterID+","+Operations.bookingList[i].SeatCount+","+Operations.bookingList[i].TotalAmount+","+Operations.bookingList[i].BookingStatus;


            }
            File.WriteAllLines("MovieTicketBooking/BookingDetails.csv",bookingDetails);

            string[] movieDetails=new string[Operations.movieList.Count];
            for(int i=0;i<Operations.movieList.Count;i++)
            {
                //MovieID,MovieName,MovieLanguage
                movieDetails[i]=Operations.movieList[i].MovieID+","+Operations.movieList[i].MovieName+","+Operations.movieList[i].MovieLanguage;

            }
            File.WriteAllLines("MovieTicketBooking/MovieDetails.csv",movieDetails);

            string[] screeningDetails=new string[Operations.screeningList.Count];
            for(int i=0;i<Operations.screeningList.Count;i++)
            {
                //movieid,TheatedID,TicketPrice,SeatAvailabilety
                screeningDetails[i]=Operations.screeningList[i].MovieID+","+Operations.screeningList[i].TheaterID+","+Operations.screeningList[i].NoOfSeatsAvailable+","+Operations.screeningList[i].TicketPrice;

            }
            File.WriteAllLines("MovieTicketBooking/ScreeningDetails.csv",screeningDetails);

            string[] theaterDetails=new string[Operations.theaterList.Count];
            for(int i=0;i<Operations.theaterList.Count;i++)
            {
                //TheaterID,TheaterName,TheaterLocation
                theaterDetails[i]=Operations.theaterList[i].TheaterID+","+Operations.theaterList[i].TheaterName+","+Operations.theaterList[i].TheaterLocation;

            }
            File.WriteAllLines("MovieTicketBooking/TheaterDetails.csv",theaterDetails);

            string[] userDetails=new string[Operations.userList.Count];
            for(int i=0;i<Operations.userList.Count;i++)
            
            {
                userDetails[i]=Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].WalletBalance;

            }
            File.WriteAllLines("MovieTicketBooking/UserDetails.csv",userDetails);
        }
        public static void Read()
        {
            string[] bookingInfo=File.ReadAllLines("MovieTicketBooking/BookingDetails.csv");
            foreach(string data in bookingInfo)
            {
                BookingDetails booking=new BookingDetails(data);
                Operations.bookingList.Add(booking);
                
            }

            string[] movieInfo=File.ReadAllLines("MovieTicketBooking/MovieDetails.csv");
            foreach(string data in movieInfo)
            {
                MovieDetails movie=new MovieDetails(data);
                Operations.movieList.Add(movie);
                
            }
            string[] screeningInfo=File.ReadAllLines("MovieTicketBooking/ScreeningDetails.csv");
            foreach(string data in screeningInfo)
            {
                ScreeningDetails screening=new ScreeningDetails(data);
                Operations.screeningList.Add(screening);
                
            }
            string[] theaterInfo=File.ReadAllLines("MovieTicketBooking/TheaterDetails.csv");
            foreach(string data in theaterInfo)
            {
                TheaterDetails theater=new TheaterDetails(data);
                Operations.theaterList.Add(theater);
                
            }

            string[] userInfo=File.ReadAllLines("MovieTicketBooking/UserDetails.csv");
            foreach(string data in userInfo)
            {
                string[] values=data.Split(',');
                UserDetails newUser=new UserDetails(values[1],int.Parse(values[2]),long.Parse(values[3]),double.Parse(values[4]));
                Operations.userList.Add(newUser);


            }

        }
    }
}