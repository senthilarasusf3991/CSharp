namespace Question1
{


    public class Cylinders:Shape
    {
        public override double Area{get{return area;}set {area=value;}}
        public override double Volume { get {return volume;} set {volume=value;}}
        public override void CalculateArea()
        {
            Area=2*3.14*Radius*(Radius+Height);
        }
        public Cylinders(double radius,double height)
        {
            Radius=radius;
            Height=height;
        }
        public override void CalculateVolume()
        {
            Volume=3.14*(Radius*Radius)*Height;
        }
    }
}