using System;
namespace AbstractClass
{
    public abstract class Employee 
    {
        protected string name;  //normal field
        public abstract string Name {get; set;}  //Abstract Property
        public double Amount {get; set;}  // Normal Property
        public void Display(){Console.WriteLine(name);} //Normal method

        public abstract void Salary(int dates); //Abstract method
    }
}