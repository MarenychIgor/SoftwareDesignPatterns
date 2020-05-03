using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Auxilary.Components
{
    public class Engine
    {
        public double Capacity { get; private set; }
        public int Power { get; private set; }
        public int Cylinders { get; private set; }
        public EngineType Type { get; private set; }
        public FuelType Fuel { get; private set; }

        public Engine()
        {
            Capacity = default;
            Power = default;
            Cylinders = default;
            Type = EngineType.None;
            Fuel = FuelType.None;
        }

        public Engine(double capacity, int power, int cylinders, EngineType engine, FuelType fuel)
        {
            Capacity = capacity;
            Power = power;
            Cylinders = cylinders;
            Type = engine;
            Fuel = fuel;
        }
    }
}
