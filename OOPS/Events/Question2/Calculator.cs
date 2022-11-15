namespace Question2
{
    public class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public void Addition()
        {
            System.Console.WriteLine($"Addition : {Number1 + Number2}");
        }
        public void Subtraction()
        {
            System.Console.WriteLine($"Subtraction : {Number1 - Number2}");
        }
        public void Multiplication()
        {
            System.Console.WriteLine($"Multiplication : {Number1 * Number2}");
        }
        public void Division()
        {
            System.Console.WriteLine($"Division : {Number1 / Number2}");
        }
    }
}