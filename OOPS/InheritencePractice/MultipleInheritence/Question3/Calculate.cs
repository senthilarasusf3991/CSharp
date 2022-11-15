namespace Question3
{

    public interface ICalculate
    {
         public void Deposit(int amount);
         public void Withdraw(int amount);
         public int BalanceCheck();
    }
}