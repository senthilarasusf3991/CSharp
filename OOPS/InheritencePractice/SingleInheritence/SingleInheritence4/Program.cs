
using System;
using System.Collections.Generic;
namespace SingleInheritence4
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<BookInfo> bookList=new List<BookInfo>();
            BookInfo book1=new BookInfo("Pharma","B.Tech","SterileTechnology","PadmaThangaParameswari",350);
            bookList.Add(book1);
            
            BookInfo book2=new BookInfo("Pharma","B.Tech","SolidDosageForms","Durga",520);
            bookList.Add(book2);
            
            BookInfo book3=new BookInfo("Pharma","B.Tech","Neutraceuticals","Revathi",420);
            bookList.Add(book3);
            
            BookInfo book4=new BookInfo("Pharma","B.Tech","BioChemistry","Jothi",621);
            bookList.Add(book4);
            
         
            foreach(BookInfo book in bookList)
            {
                if(book.BookID.Equals("BID101"))
                {
                    System.Console.WriteLine("-----BOOK INFORMATION-----");
                    book.ShowBookInfo();
                     
                }

            }   
        }
    }
}