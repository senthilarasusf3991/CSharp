using System;
using System.Collections.Generic;
namespace OnlineLibraryManagement
{
    public static class Operations
    {
        private static List<UserDetails> userList=new List<UserDetails>();
        private static List<BookDetails> bookList=new List<BookDetails>();
        private static List<BorrowDetails> borrowedList=new List<BorrowDetails>();
        private static UserDetails user;
        public static void DefaultUserDetails()
        {
            UserDetails user1=new UserDetails("Ravichandran",Gender.Male,Department.EEE,"9938388333","ravi@gmail.com");
            userList.Add(user1);
            UserDetails user2=new UserDetails("Priyadharshini",Gender.Female,Department.CSE,"9938399333","9938388333");
            userList.Add(user2);
        }
        public static void DefaultBookDetails()
        {
            BookDetails book1=new BookDetails("C#","Author1",3);
            BookDetails book2=new BookDetails("HTML","Author2",5);
            BookDetails book3=new BookDetails("CSS","Author1",3);
            BookDetails book4=new BookDetails("JS","Author1",3);
            BookDetails book5=new BookDetails("TS","Author2",2);
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);
        }
        public static void DefaultBorrowedDetails()
        {
            BorrowDetails borrowed1=new BorrowDetails("BID101","SF3001",DateTime.Parse("10/04/2022"),Status.Borrowed);
            BorrowDetails borrowed2=new BorrowDetails("BID103","SF3001",DateTime.Parse("12/04/2022"),Status.Borrowed);
            BorrowDetails borrowed3=new BorrowDetails("BID104","SF3001",DateTime.Parse("15/04/2022"),Status.Returned);
            BorrowDetails borrowed4=new BorrowDetails("BID102","SF3002",DateTime.Parse("11/04/2022"),Status.Borrowed);
            BorrowDetails borrowed5=new BorrowDetails("BID105","SF3002",DateTime.Parse("15/04/2022"),Status.Returned);
            borrowedList.Add(borrowed1);
            borrowedList.Add(borrowed2);
            borrowedList.Add(borrowed3);
            borrowedList.Add(borrowed4);
            borrowedList.Add(borrowed5);

        }
        public static void MainMenu()
        {
            
            int option;
            do
            {
                System.Console.WriteLine("1.User Registration 2.Login 3.Exit");
                System.Console.WriteLine("Enter the choice: ");
                option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        UserRegistration();
                        break;
                    }
                    case 2:
                    {
                        Login();
                        break;
                    }
                    case 3:
                    {
                        
                        break;
                    }
                    default :
                    {
                        System.Console.WriteLine("Invalid choice enter again: ");
                        break;
                    }

                    
                }
            }while(option!=3);
        }
        private static void Login()
        {
            int subOption;
            System.Console.WriteLine("Enter your loginID");
            string userID=Console.ReadLine();
            foreach(UserDetails checkUser in userList)
            {
                if(userID.Equals(checkUser.RegistrationID))
                {
                    user=checkUser;
                    System.Console.WriteLine("user found");
                    do
                    {
                        System.Console.WriteLine("1.Borrow Books 2.Show Borrowed history 3.Return Books 4.Exit");
                        subOption=int.Parse(Console.ReadLine());
                        switch(subOption)
                        {
                            case 1:
                            {
                                BorrowBook();
                                break;

                            }
                            case 2:
                            {
                                ShowBorrowedHistory();
                                break;

                            }
                            case 3:
                            {
                                ReturnBooks();
                                break;

                            }
                            case 4:
                            {
                                
                                break;

                            }
                            default :
                            {
                                System.Console.WriteLine("Invalid entry enter the Option again");
                                break;

                            }

                        }
                    }while(subOption!=4);
                    

                }
            }
        }
        private static void UserRegistration()
        {
            Gender holderGender=Gender.Default;
            Department department=Department.Default;
            System.Console.WriteLine("Enter your name: ");
            string name=Console.ReadLine();
            Console.Write("Select your gender Male,Female,Transgender: ");
            while(!Enum.TryParse<Gender> (Console.ReadLine(),true,out holderGender) || !(((int)holderGender>0) && ((int)holderGender<4)))
                System.Console.WriteLine("Invalid entry Enter again");
            System.Console.WriteLine("Enter your department ECE, EEE, CSE");
            while (!Enum.TryParse<Department> (Console.ReadLine(),true,out department) || !(((int)department>0)&&((int)department<4)))
                System.Console.WriteLine("Invalid enter again");
            System.Console.WriteLine("Enter your mobile number");
            string mobileNo=Console.ReadLine();
            System.Console.WriteLine("Enter your mail id");
            string mailID=Console.ReadLine();
            
            UserDetails details=new UserDetails(name,holderGender,department,mobileNo,mailID);
            userList.Add(details);
            System.Console.WriteLine("Your Registration ID is"+details.RegistrationID);
            
        }
        
        private static void BorrowBook()
        {
            System.Console.WriteLine("|------------------------------------------------|");
            System.Console.WriteLine("| Book ID | Book Name | Author Name | Book Count |");
            System.Console.WriteLine("|------------------------------------------------|");
            foreach(BookDetails books in bookList)
            {
                System.Console.WriteLine("|{0,-10}|{1,-12}|{2,-14}|{3,-13}",books.BookID,books.BookName,books.AuthorName,books.BookCount);
                System.Console.WriteLine("|------------------------------------------------|");

            }
            System.Console.WriteLine("Enter Book ID to borrow");
            string userBookID=Console.ReadLine();
            int Count=0;
            foreach(BookDetails books in bookList)
            {
                if(userBookID.Equals(books.BookID))
                {
                    if(books.BookCount>0)
                    {
                        foreach(BorrowDetails borrow in borrowedList)
                        {
                            if((user.RegistrationID.Equals(borrow.RegistrationID)) && (borrow.RegistrationID=="Borrowed"))
                            {
                                Count++;
                            }
                        }
                        if(Count>=3)
                        {
                            System.Console.WriteLine("You have already reached the borrow book limit, so you cannot borrow books now");
                        }else
                        {
                            BorrowDetails borrowed =new BorrowDetails(books.BookID,user.RegistrationID,DateTime.Today,Status.Borrowed);
                            borrowedList.Add(borrowed);
                            foreach(BookDetails book in bookList)
                            {
                                if(book.BookID==userBookID)
                                {
                                    book.BookCount--;
                                }
                            }
                        }

                    }
                    else
                    {
                        System.Console.WriteLine("Books are not available for the selected count: ");
                        DateTime checkDateAvalilability=new DateTime();
                        foreach(BorrowDetails borrow in borrowedList)
                        {
                            if(userBookID.Equals(borrow.BookID))
                            {
                                checkDateAvalilability=borrow.BorrowedDate;
                                if(checkDateAvalilability>borrow.BorrowedDate)
                                {
                                    checkDateAvalilability=borrow.BorrowedDate;
                                }
                            }
                        }
                        System.Console.WriteLine("The book will be avalilable on "+checkDateAvalilability.AddDays(15).ToShortDateString());

                    }
                }
            }
        }
        private static void ShowBorrowedHistory()
        {
            System.Console.WriteLine("|-------------------------------------------------------------------|");

            System.Console.WriteLine("| BorrowedID | BookID | RegistrationID | Borrowed Date |   Status   |");
            System.Console.WriteLine("|-------------------------------------------------------------------|");
            foreach(BorrowDetails borrow in borrowedList)
            {
                if(user.RegistrationID.Equals(borrow.RegistrationID))
                {
                    System.Console.WriteLine("|{0,-10}|{1,-8}|{2,-16}|{3,-15}|{4,-12}|",borrow.BorrowedID,borrow.BookID,borrow.RegistrationID,borrow.BorrowedDate.ToShortDateString(),borrow.Status);
                    System.Console.WriteLine("|-------------------------------------------------------------------|");
                }
            }

            
        }
        private static void ReturnBooks()
        {
            System.Console.WriteLine("|---------------------------------------------------------------------------------------|");
            System.Console.WriteLine("| BorrowedID | BookID | RegistrationID | Borrowed Date |     Status     |   Due Date    |");
            foreach(BorrowDetails borrow in borrowedList)
            {
                if((user.RegistrationID.Equals(borrow.RegistrationID))&&(borrow.Status==Status.Borrowed))
                {
                    System.Console.WriteLine("|{0,-10}|{1,-8}|{2,-16}|{3,-15}|{4,-16}|{5,-14}",borrow.BorrowedID,borrow.BookID,borrow.RegistrationID,borrow.BorrowedDate.ToShortDateString(),borrow.Status,borrow.BorrowedDate.AddDays(15).ToShortDateString());
                    System.Console.WriteLine("|---------------------------------------------------------------------------------------|");
                }
            }
            System.Console.WriteLine("Enter the borrowed ID to returen book");
            string returnBID=Console.ReadLine();
            TimeSpan newTime;
            foreach(BorrowDetails borrow in borrowedList)
            {
                if(returnBID.Equals(borrow.BorrowedID))
                {
                    if(borrow.BorrowedDate.AddDays(15)<DateTime.Today)
                    {
                        newTime=DateTime.Today.Subtract(borrow.BorrowedDate.AddDays(15));
                        System.Console.WriteLine("The amount to be paid is "+newTime.TotalDays);
                        System.Console.WriteLine("Do you want to pay the fine now? YES or NO");
                        string answer=Console.ReadLine().ToLower();
                        if(answer=="yes")
                        {
                            System.Console.WriteLine("Book returned successfully");
                            foreach(BookDetails book in bookList)
                            {
                                if(book.BookID.Equals(borrow.BookID))
                                {
                                    book.BookCount++;
                                }
                            }
                            borrow.Status=Status.Returned;
                        }  
                    }
                    else
                    {
                        System.Console.WriteLine("Do you want to return the book now? yes or no");
                        string retAns=Console.ReadLine().ToLower();
                        if(retAns=="yes")
                        {
                            borrow.Status=Status.Returned;
                        }
                        

                    }
                }
            }
        }
    }
}
    
