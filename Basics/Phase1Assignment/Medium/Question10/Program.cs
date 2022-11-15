using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        { 
            System.Console.WriteLine("Enter a number: ");
            int num=int.Parse(Console.ReadLine());
            for (int i=1;i<=num;i++)
            {
                if (i==1 || i==num)
                {
                    for (int j=1;j<=num*3;j++)
                    {
                        System.Console.Write("*");
                    }System.Console.WriteLine();
                }
                else{
                    for(int j=1;j<=num*3;j++)
                    {
                        if(j==1 || j==num*3)
                        {
                            System.Console.Write("*");
                        }
                        else{
                            System.Console.Write(" ");
                        }
                        
                    }System.Console.WriteLine();
            
                }
            }
        }
    }
}