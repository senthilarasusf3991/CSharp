using System;
using System.Collections.Generic;

namespace FilterDelegate;
public delegate bool MyFilterDelegate(Person p);
class Program
{
    
    public static void Main(string[] args)
    {
        Person person1 =new Person() {Name="Senthil",Age=22};
        Person person2 =new Person() {Name="Balu",Age=50};
        Person person3 =new Person() {Name="keerthi",Age=10};
        Person person4 =new Person() {Name="Thiru",Age=15};
        Person person5 =new Person() {Name="Abi",Age=25};
        Person person6 =new Person() {Name="Jeyalakshmi",Age=45};

        //create al list of a person objects and fil it

        List<Person> people =new List<Person>(){person1,person2,person3,person4,person5,person6};

        // Invoke Display people using appropriate delegate
        DisplayPeople("Children",people,IsChild);
        DisplayPeople("Adults",people,IsAdult);
        DisplayPeople("Seniors",people,IsSenior);
        DisplayPeople("Voters",people,IsVoter);


    }
    static void DisplayPeople(string title, List<Person> people , MyFilterDelegate filter)
    {
        System.Console.WriteLine("People in "+title+" list are: ");
        foreach(Person p in people)
        {
            if (filter(p))
            {
                System.Console.WriteLine("{0}, is {1} Years old",p.Name,p.Age);
            }
        }
    }
    static bool IsChild(Person p) { return p.Age < 15; }
    static bool IsVoter(Person p) { return p.Age>=18;}
    static bool IsAdult(Person p ) {if( p.Age>=18 && p.Age<50){ return true; } else return false;}
    static bool IsSenior(Person p) { return p.Age>=50; }
}