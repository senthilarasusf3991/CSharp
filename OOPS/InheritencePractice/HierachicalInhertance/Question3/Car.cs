using System;
namespace Question3
{
    public enum FuelType{Petrol,Diesel}
    public class Car
    {
        public FuelType FuelType { get; set; }
        public int  NoOfSeats { get; set; }
        public string Color { get; set; }
        public double TankCapacity { get; set; }
        public double NoOfKmDriven { get; set; }
        public double Milage { get; set; }
        
        
        public void CalculateMilage(int km,int litres)
        {
            Milage=km/litres;
        }
        
        
        
        
        
        
    }
}