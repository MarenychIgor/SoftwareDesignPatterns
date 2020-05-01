using Patterns.Creational.Builder.Abstraction;
using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Implementation.Builders
{
    public class BicycleBuilder : VehicleBuilder
    {
        public override VehicleType GetVehicleType()
            => VehicleType.Bicycle;

        public override Manufacturer GetManufacturer()
            => new Manufacturer(brand: "BMX", model: "Street", year: 1992);

        public override Engine GetEngine()
            => new Engine();

        public override Safety GetSafety()
            => new Safety();

        public override Transmission GetTransmission()
            => new Transmission();

        public override Wheels GetWheels()
            => new Wheels(count: 2, diameter: 20);
    }
}
