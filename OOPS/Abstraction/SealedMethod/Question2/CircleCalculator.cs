namespace Question2
{
    public class CircleCalculator:Calculator
    {
        public int Radius { get; set; }
        
        public CircleCalculator(int radius)
        {
            Radius=radius;
        }
        public sealed override void Area()
        {
            System.Console.WriteLine("Circle Area is "+(3.14*Radius*Radius));
        }
        public sealed override void Volume()
        {
            
        }
    }
}