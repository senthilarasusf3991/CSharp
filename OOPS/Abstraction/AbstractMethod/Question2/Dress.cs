using System;
namespace Question2
{
    public enum DressType{Ladieswear,Menswear,Childrenswear}
    public abstract class Dress
    {
        public abstract DressType DressType{get;set;}
        public abstract string Name{get;set;}
        public abstract int TotalPrice{get;set;}
        public abstract void GetDressInfo();
        public abstract void DisplayInfo();
    }
}