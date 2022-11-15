using System;
namespace Question4
{
    public class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public void Addition(object sender, EventArgs e)
        {
            System.Console.WriteLine($"Addition : {Number1 + Number2}");
        }
        public void Subtraction(object sender, EventArgs e)
        {
            System.Console.WriteLine($"Subtraction : {Number1 - Number2}");
        }
        public void Multiplication(object sender, EventArgs e)
        {
            System.Console.WriteLine($"Multiplication : {Number1 * Number2}");
        }
        public void Division(object sender, EventArgs e)
        {
            System.Console.WriteLine($"Division : {Number1 / Number2}");
        }
    }
}