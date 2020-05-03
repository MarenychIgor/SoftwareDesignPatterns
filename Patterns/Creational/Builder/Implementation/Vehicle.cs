using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Implementation
{
    /// <summary>
    /// The 'Product' class.
    /// Represents the complex object under construction.
    /// Includes classes that define the constituent parts.
    /// </summary>
    public class Vehicle
    {
        public VehicleType Type { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Engine Engine { get; set; }
        public Safety Safety { get; set; }
        public Transmission Transmission { get; set; }
        public Wheels Wheels { get; set; }
    }
}
