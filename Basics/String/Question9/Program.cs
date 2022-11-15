
using System;
namespace Question9
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] strArr = new string[1000];
            int index=-1;
            string str="", user, subuser;

            System.Console.Write("Enter sentence: ");
            user = Console.ReadLine().ToLower();
            System.Console.Write("Enter Substring: ");
            subuser = Console.ReadLine().ToLower();
            
            foreach(char ch in user)
            {
                if(ch!=' ')
                {
                    str += ""+ch;
                }
                else{
                    strArr[++index] = str;
                    str="";
                }
            }
            strArr[++index] = str;

            foreach(string word in strArr)
            {
                if(word == subuser)
                System.Console.WriteLine("Substring is present");
            }
        }
    }
}