
using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter a salary:   ");
            double salary=double.Parse(Console.ReadLine());

            if (salary>=0 && salary<=10000)
            {
                double hra=salary*0.2;
                double da=salary*0.8;
                double netsalary=(salary+hra+da);
                double salaryPerAnnum=netsalary*12;
                double tax=0.06;
                double insurance=0.01;
                double deductions=salaryPerAnnum*(tax+insurance);

                double grossSalary=(salaryPerAnnum-deductions);
                System.Console.WriteLine($"Take home salary is {netsalary}");
                System.Console.WriteLine($"GrossSalary is {grossSalary}");
            }
            else if (salary>10000 && salary<=20000)
            {
                double hra=salary*0.25;
                double da=salary*0.9;
                double netsalary=(salary+hra+da);
                double tax=0.06;
                double insurance=0.01;
                double salaryPerAnnum=netsalary*12;
                double deductions=salaryPerAnnum*(tax+insurance);


                double grossSalary=(salaryPerAnnum-deductions);
                System.Console.WriteLine($"Take home salary is {netsalary}");
                System.Console.WriteLine($"GrossSalary is {grossSalary}");
            }
            else
            {
                double hra=salary*0.30;
                double da=salary*0.95;
                double netsalary=(salary+hra+da);
                double salaryPerAnnum=netsalary*12;
                double tax=0.06;
                double insurance=0.01;
                double deductions=salaryPerAnnum*(tax+insurance);

                double grossSalary=(salaryPerAnnum-deductions);
                System.Console.WriteLine($"Take home salary is {netsalary}");
                System.Console.WriteLine($"GrossSalary is {grossSalary}");
            }
                        
            
        }
    }
}