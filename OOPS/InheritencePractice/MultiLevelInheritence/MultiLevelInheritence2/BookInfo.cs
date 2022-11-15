using System;
namespace MultiLevelInheritence2
{
    public class BookInfo:RackInfo
    {

        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        public BookInfo(string departmentName,string degree,int rackNumber,int columnNumber,string bookID ,string bookName,string authorName,double price):base(departmentName,degree,rackNumber, columnNumber)
        {
            BookID=bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine("BookID           :"+BookID);
            System.Console.WriteLine("BookName         :"+BookName);
            System.Console.WriteLine("AuthorName       :"+AuthorName);
            System.Console.WriteLine("Price            :"+Price);
            System.Console.WriteLine("DepartmentName   :"+DepartmentName);
        }

    }
}