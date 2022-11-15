namespace SingleInheritence4
{
    public class BookInfo:DepartmentDetails
    {
        private static int s_bookID=100;
        public string BookID{get;set;}
        public string BookName{get;set;}
        public string AuthorName{get;set;}
        public double Price{get;set;}
        public BookInfo(string department, string degree,string bookName,string authorName,double price):base( department,  degree)
        {
            s_bookID++;
            BookID="BID"+s_bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        
        public void ShowBookInfo()
        {
            System.Console.WriteLine($"BookName is      :{BookName}");
            System.Console.WriteLine($"AuthorName is    :{AuthorName}");
            System.Console.WriteLine($"BookID is        :{BookID}");
            System.Console.WriteLine($"Department is    :{Department}");
            System.Console.WriteLine($"Degree is        :{Degree}");
            System.Console.WriteLine($"Price is         :{Price}");
        }
    }
}