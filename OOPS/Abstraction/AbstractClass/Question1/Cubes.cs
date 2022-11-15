namespace Question1
{


    public class Cubes:Shape
    {
        public override double Area{get{return area;}set {area=value;}}
        public override double Volume { get {return volume;} set {volume=value;}}
        public override void CalculateArea()
        {
            Area=6*Side*Side;
        }
        public Cubes(double side)
        {
            Side=side;
        }
        public override void CalculateVolume()
        {
            Volume=Side*Side*Side;
        }
    }
}