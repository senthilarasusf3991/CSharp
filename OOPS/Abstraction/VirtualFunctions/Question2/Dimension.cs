namespace Question2
{
    public class Dimension
    {
        public int  Value1 { get; set; }
        public int Value2 { get; set; }
        public Dimension(int value1,int value2)
        {
            Value1=value1;
            Value2=value2;
        }
        public double Area { get; set; }
        public virtual void Calculate()
        {
            Area=Value1*Value2;
            System.Console.WriteLine($"Dimension area is  :{Area}");
        }
        public virtual void Display()
        {
            System.Console.WriteLine($"Area is:{Area}");
        }
    }
}