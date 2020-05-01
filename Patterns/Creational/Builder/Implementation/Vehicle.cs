using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Implementation
{
    public class Vehicle
    {
        public VehicleType Type { get; private set; }
        public Manufacturer Manufacturer { get; private set; }
        public Engine Engine { get; private set; }
        public Safety Safety { get; private set; }
        public Transmission Transmission { get; private set; }
        public Wheels Wheels { get; private set; }

        public Vehicle(VehicleType type, Manufacturer manufacturer, Engine engine, Safety safety, Transmission transmission, Wheels wheels)
        {
            Type = type;
            Manufacturer = manufacturer;
            Engine = engine;
            Safety = safety;
            Transmission = transmission;
            Wheels = wheels;
        }
    }
}
