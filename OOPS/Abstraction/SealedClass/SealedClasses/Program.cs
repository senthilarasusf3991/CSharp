using System;
namespace SealedClass
{
    class LivingThings
    {

    }
    
    sealed class Animal:LivingThings
    {

    }
    //Trying to inherit sealed class
    //produce Error in code
    class Dog:Animal
    {

    }
    class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
    
}