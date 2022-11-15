using System;
namespace Question2
{

    public abstract class Library
    {
        private static int _serialNumber=1000;
        public string SerialNumber{get {_serialNumber++;return "LIB"+_serialNumber;}}
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract DateTime Year { get; set; }

        public abstract void SetBookInfo(string authorName,string bookName,string publisherName,DateTime year);
        public abstract void DisplayInfo();
    }
}