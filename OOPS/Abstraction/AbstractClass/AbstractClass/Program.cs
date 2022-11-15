using System;
namespace AbstractClass
{
    class Test
    {
        static void Main(string[] args)
        {
            Syncfusion job1=new Syncfusion();
            job1.Name="Developer";
            job1.Salary(30);

            TCS job2=new TCS();
            job2.Name="Test engineer";
            job2.Salary(15);

            Console.ReadKey();

        }
    }
}