namespace Question2
{
    public class Rectangle:Dimension
    {
        public double Length { get; set; }
        public double Height { get; set; }
        public Rectangle(int value1,int value2,double length,double height):base(value1,value2)
        {
            Length=length;
            Height=height;
        }
        public override void Calculate()
        {
            base.Calculate();
            Area=Length*Height;
        }
        public override void Display()
        {
            System.Console.WriteLine($"Length :{Length}");
            System.Console.WriteLine($"Height :{Height}");
            System.Console.WriteLine($"Area   :{Area}");
        }
    }
}