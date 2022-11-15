namespace Question5
{
    public class Program
    {
        public static event Wire mainMachine;
        public static void Main(string[] args)
        {
            mainMachine += new Wire(Files.Create);
            mainMachine();
        }
    }
}