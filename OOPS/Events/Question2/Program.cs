namespace Question2
{
    public delegate void Wire();
    public class Program
    {
        public static event Wire machine;
        public static void Main(string[] args)
        {
            Calculator calci = new Calculator() {Number1 = 8, Number2 = 2};
            machine += new Wire(calci.Addition);
            machine += new Wire(calci.Subtraction);
            machine += new Wire(calci.Multiplication);
            machine += new Wire(calci.Division);
            machine();
        }
    }
}