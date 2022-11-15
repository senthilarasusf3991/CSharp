
using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the rows: ");
            int row=int.Parse(Console.ReadLine());
            

            Console.WriteLine("Enter the column: ");
            int column=int.Parse(Console.ReadLine());

            
            int[,]arr1=new int [row,column];
            for(int i=0;i<row;i++)
            {
                for (int j=0;j<column;j++)
                {
                    System.Console.WriteLine($"Enter the elements[{i}][{j}]");
                    arr1[i,j]=int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine("Enter the rows: ");
            int row2=int.Parse(Console.ReadLine());
            

            Console.WriteLine("Enter the column: ");
            int column2=int.Parse(Console.ReadLine());

            int[,]arr2=new int [row2,column2];
            for(int i=0;i<row2;i++)
            {
                for(int j=0;j<column2;j++)
                {
                    System.Console.WriteLine($"Elements [{i}][{j}]");
                    arr2[i,j]=int.Parse(Console.ReadLine());
                }
            }
            System.Console.WriteLine("The first matrix is: ");
            for (int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {

                    System.Console.Write($"{arr1[i,j]}");
                }System.Console.WriteLine();
            }

            System.Console.WriteLine("The second Matrix is: ");
            for(int i=0;i<row2;i++)
            {
                for (int j=0;j<column2;j++)
                {
                    System.Console.Write($"{arr2[i,j]}");
                }System.Console.WriteLine();
            }
            //multiplication

            
            Console.WriteLine("The multiplication of two matrix is: ");
            int [,]multiply=new int[row,column];
            for (int i=0;i<row;i++)
            {
                for (int j=0;j<column2;j++)
                {
                    for (int k=0;k<column;k++)
                    {
                        multiply[i,j]=multiply[i,j]+arr1[i,k]*arr2[k,j];

                    }System.Console.Write($"{multiply[i,j]}"+" ");
                }System.Console.WriteLine();

            }
        }
    }
}

