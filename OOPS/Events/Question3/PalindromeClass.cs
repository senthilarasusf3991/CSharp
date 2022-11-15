using System;
namespace Question3
{
    public class PalindromeClass
    {
        public string Word { get; set; }
        public string ReverseWord { get; set; }
        public void LowerCase()
        {
            Word = Word.ToLower();
            System.Console.WriteLine(Word.ToLower());
        }
        public void UpperCase()
        {
            Word = Word.ToUpper();
            System.Console.WriteLine(Word.ToUpper());
        }
        public void Reverse()
        {
            char[] wordArr = Word.ToCharArray();
            Array.Reverse<char>(wordArr);
            ReverseWord = string.Join("",wordArr);
        }
        public void Palindrome()
        {
            Reverse();
            if (Word.ToLower().Equals(ReverseWord.ToLower()))
            {
                System.Console.WriteLine("It is Palindrome");
            }
            else {
                System.Console.WriteLine("It is Not a Palindrome");
            }
        }
    }
}