using System;
namespace Question4
{
    public class Program
    {
        public static event EventHandler machine;
        public static void Main(string[] args)
        {
            Calculator calci = new Calculator() {Number1 = 8, Number2 = 2};
            machine += new EventHandler(calci.Addition);
            machine += new EventHandler(calci.Subtraction);
            machine += new EventHandler(calci.Multiplication);
            machine += new EventHandler(calci.Division);
            machine(calci, EventArgs.Empty);
        }
    }
}