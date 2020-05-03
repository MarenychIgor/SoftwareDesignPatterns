namespace Patterns.Creational.Builder.Auxilary.Components
{
    public class Wheels
    {
        public int Count { get; private set; }
        public int Diameter { get; private set; }

        public Wheels(int count, int diameter)
        {
            Count = count;
            Diameter = diameter;
        }
    }
}
