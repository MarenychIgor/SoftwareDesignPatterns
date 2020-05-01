using Patterns.Creational.Builder.Abstraction;
using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Implementation.Builders
{
    public class CarBuilder : VehicleBuilder
    {
        public override Vehicle Build()
            => new Vehicle(VehicleType.Car, BuildManufacturer(), BuildEngine(), BuildSafety(), BuildTransmission(), BuildWheels());

        protected override Manufacturer BuildManufacturer()
            => new Manufacturer(brand: "Toyota", model: "Camry", year: 2014);

        protected override Engine BuildEngine()
            => new Engine(capacity: 2.5, power: 181, cylinders: 4, EngineType.Atmospheric, FuelType.Petrol);

        protected override Safety BuildSafety()
            => new Safety(airbags: 9);

        protected override Transmission BuildTransmission()
            => new Transmission(gears: 6, TransmissionType.Automatic, DriveType.FrontWheelDrive);

        protected override Wheels BuildWheels()
            => new Wheels(count: 4, diameter: 17);
    }
}
