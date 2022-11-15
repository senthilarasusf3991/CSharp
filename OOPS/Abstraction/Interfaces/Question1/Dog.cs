namespace Question1
{
    public class Dog:IAnimal
    {
        public string Name { get; set; }
         public string Habitat { get; set; }
         public string EatingHabit { get; set; }
         public Dog(string name,string habitat,string eatingHabit)
         {
            Name=name;
            Habitat=habitat;
            EatingHabit=eatingHabit;
         }
        public void DisplayName()
        {
            System.Console.WriteLine($"Name is  :{Name}");
        }
    }
}