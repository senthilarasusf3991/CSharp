using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        int[]purchase={60,80,100,110};
        OnlineTransaction online=new OnlineTransaction(purchase,DateTime.Today);
        online.CalculateAmount();
        online.DisplayBill();

        int[]purchaseOne={60,80,100,110,90,70};
        OnlineTransaction offline=new OnlineTransaction(purchaseOne,DateTime.Today);
        offline.CalculateAmount();
        offline.DisplayBill();
    }
}