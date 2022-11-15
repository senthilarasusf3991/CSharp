namespace Question2
{
    public class DisplayMethod
    {
        public int Display(int num1)
        {
            return num1;
        }
        public int Display(int num1, int num2)
        {
            return num1*num2;
        }
        public void Display (int num1 , string str1)
        {
            System.Console.WriteLine(num1);
            System.Console.WriteLine(str1);
        }
        public void Display (int num1 , string str1, double price)
        {
            System.Console.WriteLine(num1);
            System.Console.WriteLine(str1);
            System.Console.WriteLine(price);
        }
    }
}