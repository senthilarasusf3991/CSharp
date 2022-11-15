
using System;
using System.Collections.Generic;
namespace MultiLevelInheritence2;
class Program{
    public static void Main(string[] args)
    {
        List<BookInfo>bookList=new List<BookInfo>();
        BookInfo book1=new BookInfo("PharmaceuticalTech","B.Tech",3,4,"BID102","DosageForms","Senthil",500);
        BookInfo book2=new BookInfo("PharmaceuticalTech","B.Tech",3,5,"BID101","DosageForms","priyan",479);
        BookInfo book3=new BookInfo("PharmaceuticalTech","B.Tech",3,5,"BID102","DosageForms","mathi",481);
        bookList.Add(book1);
        bookList.Add(book2);
        bookList.Add(book3);
        foreach(BookInfo books in bookList)
        {
            books.DisplayInfo();
        }
    }
}