using System;
namespace Question3
{
    public interface ITransaction
    {
         public int TotalAmount { get; set; }
         public void CalculateAmount();
         public void DisplayBill();
         
         
    }
}