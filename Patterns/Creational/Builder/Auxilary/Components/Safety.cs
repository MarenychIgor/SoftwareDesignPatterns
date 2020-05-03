namespace Patterns.Creational.Builder.Auxilary.Components
{
    public class Safety
    {
        public int Airbags { get; private set; }

        public Safety()
            => Airbags = default;

        public Safety(int airbags)
            => Airbags = airbags;
    }
}
