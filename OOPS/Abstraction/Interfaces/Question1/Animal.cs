namespace Question1
{


    public interface IAnimal
    {
         public string Name { get; set; }
         public string Habitat { get; set; }
         public string EatingHabit { get; set; }
         public void DisplayName();
         
         
    }
}