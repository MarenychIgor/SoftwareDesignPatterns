using Patterns.Creational.Builder.Abstraction;
using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Implementation.Builders
{
    public class BicycleBuilder : VehicleBuilder
    {
        public override Vehicle Build()
            => new Vehicle(VehicleType.Bicycle, BuildManufacturer(), BuildEngine(), BuildSafety(), BuildTransmission(), BuildWheels());

        protected override Manufacturer BuildManufacturer()
            => new Manufacturer(brand: "BMX", model: "Street", year: 1992);

        protected override Engine BuildEngine()
            => new Engine();

        protected override Safety BuildSafety()
            => new Safety();

        protected override Transmission BuildTransmission()
            => new Transmission();

        protected override Wheels BuildWheels()
            => new Wheels(count: 2, diameter: 20);
    }
}
