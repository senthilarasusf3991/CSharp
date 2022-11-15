using System;
namespace MovieTicketBooking
{
    public partial class Operations
    {
        public static List<UserDetails> userList=new List<UserDetails>();
        public static List<TheaterDetails> theaterList=new List<TheaterDetails>();
        public static List<MovieDetails> movieList=new List<MovieDetails>();
        public static List<ScreeningDetails> screeningList=new List<ScreeningDetails>();
        public static List<BookingDetails> bookingList=new List<BookingDetails>();
        
        public static UserDetails CurrentUser;
        
        public static void MainMenu()
        {
            int option;
            System.Console.WriteLine("Welcome to Mainmenu");
            do
            {

            
                System.Console.WriteLine("1.User Registration 2.Login 3.Exit");
                option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Login();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("exit");
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("invalid choice");
                        break;
                    }
                }

            }while(option!=3);
            
        }
        private static void Registration()
        {
        
            int age;
            long phoneNumber;
            double walletBalance;
            System.Console.WriteLine("Enter your Name: ");
            string name=Console.ReadLine();
            
            System.Console.WriteLine("Enter Your Age: ");
            bool temp=int.TryParse(Console.ReadLine(),out age);
            while(!temp)
            {
                System.Console.WriteLine("Invalid Input enter in correct format");
                System.Console.WriteLine("Enter Your age: ");
                temp=int.TryParse(Console.ReadLine(),out age);
            }
            System.Console.WriteLine("Enter your Phone Number: ");
             temp=long.TryParse(Console.ReadLine(),out phoneNumber);
             while(!temp)
             {
                System.Console.WriteLine("Invalid Input enter in correct format");
                System.Console.WriteLine("Enter Your phone numeber: ");
                temp=long.TryParse(Console.ReadLine(),out phoneNumber);
             }
            System.Console.WriteLine("Enter your wallet balance: ");
            temp=double.TryParse(Console.ReadLine(),out walletBalance);
            while (!temp)
            {
                System.Console.WriteLine("Invalid Input enter in correct format");
                System.Console.WriteLine("Enter Your WalletBalance: ");
                temp=double.TryParse(Console.ReadLine(),out walletBalance);
            }

            UserDetails user = new UserDetails(name,age,phoneNumber,walletBalance);
            userList.Add(user);
            Console.ForegroundColor=ConsoleColor.Green;
            System.Console.WriteLine($"Registration Succussfull your UserID is {user.UserID}");
            Console.ResetColor();

        }
        private static void Login()
        {
            System.Console.WriteLine("Enter Your UserID: ");
            string userID=Console.ReadLine().ToUpper();
            bool flag = true;
            foreach(UserDetails user in userList)
            {
                if(user.UserID.Equals(userID))
                {
                    flag=false;
                    CurrentUser=user;
                    Console.ForegroundColor=ConsoleColor.Green;
                    System.Console.WriteLine("UserID found");
                    Console.ResetColor();
                    SubMenu();

                }
            }
            if(flag)
            {
                System.Console.WriteLine("Invalid UserID");
            }
        }
        private static void SubMenu()
        {
                
            int subOption;
            do{
                System.Console.WriteLine("1.Ticket Booking");
                System.Console.WriteLine("2.Ticket Cancellation");
                System.Console.WriteLine("3.Booking History");
                System.Console.WriteLine("4.Wallet Recharge");
                System.Console.WriteLine("5.Exit");
                System.Console.WriteLine("Enter the option");
                subOption=int.Parse(Console.ReadLine());
                switch(subOption)
                
                {
                    case 1:
                    {
                        TicketBooking();
                        break;
                    }
                    case 2:
                    {
                        TicketCancellation();
                        break;
                    }
                    case 3:
                    {
                        BookingHistory();
                        break;
                    }
                    case 4:
                    {
                        WalletRecharge();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("Thank You");
                        break;
                    }
                    default :
                    {
                        Console.ForegroundColor=ConsoleColor.Red;
                        System.Console.WriteLine("Invalid Option enter the correct choice");
                        Console.ResetColor();
                        break;
                    }
                }


            }while(subOption!=5);
        }
        private static void TicketBooking()
        {
            string conditon="";
            int screenSeatCount=0;
            double TotalAmount;
            bool temp;
            int seatCount=0;
            bool flag=true,checkMovie=true,checkScreening=true;
            System.Console.WriteLine("|---------------------------------------------------|");
            System.Console.WriteLine("|  TheaterID      | Theater Name   |  Location      |");
            System.Console.WriteLine("|---------------------------------------------------|");
            foreach(TheaterDetails theater in theaterList)
            {
                theater.ShowTheaterDeatailas();
                System.Console.WriteLine("|---------------------------------------------------|");
            }
            System.Console.WriteLine("Select a theater using Theater ID: ");
            string theaterID=Console.ReadLine().ToUpper();
            foreach(TheaterDetails theater in theaterList)
            {
                
                if(theaterID.Equals(theater.TheaterID))
                {
                    flag=false;
                    System.Console.WriteLine("|---------------------------------------------------|");
                    System.Console.WriteLine("|      MovieID    | Movie Name     |  Language      |");
                    System.Console.WriteLine("|---------------------------------------------------|");
                    foreach (ScreeningDetails screening in screeningList)
                    {
                        foreach(MovieDetails movie in movieList)
                        {
                            if((screening.MovieID.Equals(movie.MovieID)&&screening.TheaterID.Equals(theaterID)))
                            {
                            movie.ShowMovieDetails();
                            System.Console.WriteLine("|---------------------------------------------------|");
                            }
                        }
                    }
                    System.Console.WriteLine("Select a movie using movie ID");
                    string movieID=Console.ReadLine().ToUpper();
                    foreach(MovieDetails movie in movieList)
                    {
                        if (movieID.Equals(movie.MovieID))
                        {
                            checkMovie=false;
                            System.Console.WriteLine("Enter the seat count: ");
                            temp=int.TryParse(Console.ReadLine(),out seatCount);
                            while(!temp)
                            {
                                System.Console.WriteLine("Enter Seat count in numbers: ");
                                temp=int.TryParse(Console.ReadLine(),out seatCount);
                            }
                            foreach(ScreeningDetails screening in screeningList)
                            {
                                if((screening.MovieID.Equals(movieID) &&  screening.NoOfSeatsAvailable>=seatCount))
                                {
                                    checkScreening=false;
                                    screenSeatCount=screening.NoOfSeatsAvailable;
                                    TotalAmount=(seatCount*screening.TicketPrice)+(0.18*(seatCount*screening.TicketPrice));
                                    System.Console.WriteLine("Do You want to take the Booking: yes or no");
                                    conditon=Console.ReadLine().ToLower();
                                    while(conditon=="yes")
                                    {
                                        
                                        if(CurrentUser.WalletBalance>=TotalAmount)
                                        {
                                           
                                            CurrentUser.WalletBalance=CurrentUser.WalletBalance-TotalAmount;
                                            screening.NoOfSeatsAvailable-=seatCount;

                                            BookingDetails newBooking=new BookingDetails(CurrentUser.UserID,movie.MovieID,theater.TheaterID,seatCount,TotalAmount,BookingStatus.Booked);
                                            bookingList.Add(newBooking);

                                            System.Console.WriteLine($"Booking Successfull .Your Booking ID is{newBooking.BookingID} and charge is {TotalAmount}");
                                            return;
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("Your wallet balance is Insufficient for booking...Please recharge your wallet");
                                            WalletRecharge();
                                            System.Console.WriteLine("Do You want to Take booking now: Yes or No");
                                            conditon=Console.ReadLine().ToLower();   
                                        }
                                    }
                                    


                                }
                                
                            }
                            if(checkScreening)
                            {
                                Console.ForegroundColor=ConsoleColor.Red;
                                System.Console.WriteLine($"Required seat count is not availabe, Current count is {screenSeatCount}");
                                Console.ResetColor();
                            }
                            
                            

                        }
                        
                    }
                    if(checkMovie)
                    {
                        Console.ForegroundColor=ConsoleColor.Red;
                        System.Console.WriteLine("Invalid movie id");
                        Console.ResetColor();
                    }
                }
                
            }
            if(flag)
            {
                Console.ForegroundColor=ConsoleColor.Red;
                System.Console.WriteLine("Invalid theater id");
                Console.ResetColor();
            }
        }
        private static void TicketCancellation()
        {
            string bookingID;
            bool flag =true,check=true;
            System.Console.WriteLine("|------------------------------------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("| Booking ID      |       userID    |       MovieID   |    TheaterID    |    SeatCount    |    TotalAmount  |    BookingStatus |");
            System.Console.WriteLine("|------------------------------------------------------------------------------------------------------------------------------|");
            foreach(BookingDetails booking in bookingList)
            {
                if(CurrentUser.UserID.Equals(booking.UserID))
                {
                    flag=false;
                    booking.ShowBookingHistory();
                    System.Console.WriteLine("|------------------------------------------------------------------------------------------------------------------------------|");
                }
            }
            if(flag)
            {
                System.Console.WriteLine("No booking history in your account");
            }
            System.Console.WriteLine("Enter the booking ID you want to cancel");
            bookingID=Console.ReadLine().ToUpper();
            foreach(BookingDetails booking in bookingList)
            {
               
                if((booking.BookingID.Equals(bookingID))&&(booking.BookingStatus.Equals(BookingStatus.Booked)))
                {
                    check=false;
                    foreach(ScreeningDetails screening in screeningList)
                    {
                        if((screening.MovieID.Equals(booking.MovieID))&&(screening.TheaterID.Equals(booking.TheaterID)))
                        {

                            screening.NoOfSeatsAvailable+=booking.SeatCount;
                            CurrentUser.WalletBalance=(CurrentUser.WalletBalance+booking.TotalAmount)-20;
                            booking.BookingStatus=BookingStatus.Cancelled;
                            Console.ForegroundColor=ConsoleColor.Green;
                            System.Console.WriteLine("Your Booking Cancelled Successfully...");
                            Console.ResetColor();
                            
                        }
                    }
                }
            }
            if(check)
            {
                System.Console.WriteLine("Invalid booking ID...");
            }
            


        }
        private static void WalletRecharge()
        {
            double amount;
            System.Console.WriteLine("Enter the amount you Want to be recharged: ");
            amount=double.Parse(Console.ReadLine());

            CurrentUser.WalletBalance+=amount;
            System.Console.WriteLine($"Recharged Successfullt , Your balance is {CurrentUser.WalletBalance}");
        }
        private static void BookingHistory()
        {
            System.Console.WriteLine("|------------------------------------------------------------------------------------------------------------------------------|");
            System.Console.WriteLine("| Booking ID      |       userID    |       MovieID   |    TheaterID    |    SeatCount    |    TotalAmount  |    BookingStatus |");
            System.Console.WriteLine("|------------------------------------------------------------------------------------------------------------------------------|");
            foreach(BookingDetails booking in bookingList)
            {     
                booking.ShowBookingHistory();
                System.Console.WriteLine("|------------------------------------------------------------------------------------------------------------------------------|");
                
            }
        }

        public static void DefaultData()
        {
            TheaterDetails theater1 =new TheaterDetails("Inox","Anna Nagar");
            theaterList.Add(theater1);
            TheaterDetails theater2 =new TheaterDetails("Ega Theater","Chetpet");
            theaterList.Add(theater2);
            TheaterDetails theater3 =new TheaterDetails("kamala","vadapalani");
            theaterList.Add(theater3);

            MovieDetails movie1 = new MovieDetails("Bagubali 2","Telugu");
            MovieDetails movie2 = new MovieDetails("Ponniyin Selvan","Tamil");
            MovieDetails movie3 = new MovieDetails("Cobra","Tamil");
            MovieDetails movie4 = new MovieDetails("Vikram","Hindi (Dubbed)");
            MovieDetails movie5 = new MovieDetails("Vikram","Tamil");
            MovieDetails movie6 = new MovieDetails("Beast","English");
            movieList.Add(movie1);
            movieList.Add(movie2);
            movieList.Add(movie3);
            movieList.Add(movie4);
            movieList.Add(movie5);
            movieList.Add(movie6);

            ScreeningDetails screen1=new ScreeningDetails("MID501","TID301",5,200);
            ScreeningDetails screen2=new ScreeningDetails("MID502","TID301",2,300);
            ScreeningDetails screen3=new ScreeningDetails("MID506","TID301",1,50);
            ScreeningDetails screen4=new ScreeningDetails("MID501","TID302",11,400);
            ScreeningDetails screen5=new ScreeningDetails("MID502","TID302",20,300);
            ScreeningDetails screen6=new ScreeningDetails("MID504","TID302",2,500);
            ScreeningDetails screen7=new ScreeningDetails("MID505","TID303",11,100);
            ScreeningDetails screen8=new ScreeningDetails("MID502","TID303",20,200);
            ScreeningDetails screen9=new ScreeningDetails("MID504","TID303",2,350);
            screeningList.Add(screen1);
            screeningList.Add(screen2);
            screeningList.Add(screen3);
            screeningList.Add(screen4);
            screeningList.Add(screen5);
            screeningList.Add(screen6);
            screeningList.Add(screen7);
            screeningList.Add(screen8);
            screeningList.Add(screen9);

            UserDetails user1=new UserDetails("Ravichandran",30,8599488003,1000);
            UserDetails user2=new UserDetails("Baskaran",30,9857747327,2000);
            userList.Add(user1);
            userList.Add(user2);

            BookingDetails booking1=new BookingDetails("UID1001","MID501","TID301",1,200,BookingStatus.Booked);
            BookingDetails booking2=new BookingDetails("UID1001","MID502","TID302",1,400,BookingStatus.Booked);
            BookingDetails booking3=new BookingDetails("UID1002","MID505","TID302",1,300,BookingStatus.Booked);
            bookingList.Add(booking1);
            bookingList.Add(booking2);
            bookingList.Add(booking3);












        }

    }
}