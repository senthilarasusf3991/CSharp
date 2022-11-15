using System;
using System.Collections.Generic;
namespace OnlineLibraryManagement;
class Program
{
    public static void Main(string[] args)
    {
        Operations.DefaultUserDetails();
        Operations.DefaultBookDetails();
        Operations.DefaultBorrowedDetails();
        Operations.MainMenu();
    }
}