namespace Patterns.Creational.Builder.Auxilary.Components
{
    public class Manufacturer
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

        public Manufacturer(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }
}
