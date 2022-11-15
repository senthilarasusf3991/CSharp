using System;
namespace OnlineLibraryManagement
{
    public enum Status{Default, Borrowed, Returned}
    public class BorrowDetails
    {
        private static int s_borrowID=300;
        public string BorrowedID{get;}
        public string BookID{get;set;}
        public string RegistrationID{get; set;}
        public DateTime BorrowedDate{get;set;}
        public Status Status {get; set;}
        public BorrowDetails (string bookID, string registrationID, DateTime borrowedDate, Status status)
        {
            s_borrowID++;
            BorrowedID="LB"+s_borrowID;
            BookID=bookID;
            RegistrationID=registrationID;
            BorrowedDate=borrowedDate;
            Status=status;
            
        }

    }
}