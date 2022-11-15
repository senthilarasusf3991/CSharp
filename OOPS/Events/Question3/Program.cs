namespace Question3
{
    public delegate void Wire();
    public class Program
    {
        public static event Wire machine;
        public static void Main(string[] args)
        {
            PalindromeClass palindrome = new PalindromeClass(){Word = "Malayalam"};
            machine += new Wire(palindrome.LowerCase);
            machine += new Wire(palindrome.UpperCase);
            machine += new Wire(palindrome.Palindrome);
            machine();
        }
    }
}