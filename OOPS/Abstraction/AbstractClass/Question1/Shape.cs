namespace Question1
{

    public abstract class Shape
    {
        protected double area;
        protected double volume;

        public abstract double Area{get;set;}
        public abstract double Volume{get;set;}
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Side {get;set;}
        public abstract void CalculateArea();
        public abstract void CalculateVolume();

    }
}