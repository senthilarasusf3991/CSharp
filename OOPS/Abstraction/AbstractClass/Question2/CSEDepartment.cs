using System;
namespace Question2
{


    public class CSEDepartment:Library
    {
        public override string AuthorName {get;set;}
        public override string BookName {get;set;}
        public override string PublisherName{get;set;}
        public override DateTime Year{get;set;}
        public CSEDepartment(string authorName,string bookName,string publisherName,DateTime year)
        {
            AuthorName=authorName;
            PublisherName=publisherName;
            Year=year;
            BookName=bookName;
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine($"AuthorName        :{AuthorName}");
            System.Console.WriteLine($"BookName          :{BookName}");
            System.Console.WriteLine($"PublisherName     :{PublisherName}");
            System.Console.WriteLine($"Year              :{Year.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine($"SeraialNumber     :{SerialNumber}");
        }
        public override void SetBookInfo(string authorName,string bookName,string publisherName,DateTime year)
        {
            AuthorName=authorName;
            PublisherName=publisherName;
            Year=year;
            BookName=bookName;
        }
    }
}