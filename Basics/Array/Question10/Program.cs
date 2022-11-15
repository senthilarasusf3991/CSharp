
using System;
namespace Question
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The first matrix; ");
            Console.Write("Enter the rows: ");
            int row=int.Parse(Console.ReadLine());

            Console.Write("Enter the column: ");
            int column=int.Parse(Console.ReadLine());

            int [,]arr=new int[row,column];
            for (int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    Console.Write("Element [i][j]  ");
                    arr[i,j]=int.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine("The First matrix is: ");
            for(int i=0;i<row;i++)
            {
                for (int j=0;j<column;j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
            //transpose
            Console.WriteLine("The Transpose of a matrix is: ");
            int [,]transpose=new int[row,column];
            for(int i=0;i<row;i++)
            {
                for (int j=0;j<column;j++)
                {
                    transpose[i,j]=arr[j,i];
                    Console.Write(transpose[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
