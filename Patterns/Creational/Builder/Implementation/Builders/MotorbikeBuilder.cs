using Patterns.Creational.Builder.Abstraction;
using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Implementation.Builders
{
    public class MotorbikeBuilder : VehicleBuilder
    {
        public override Vehicle Build()
            => new Vehicle(VehicleType.Motorbike, BuildManufacturer(), BuildEngine(), BuildSafety(), BuildTransmission(), BuildWheels());

        protected override Manufacturer BuildManufacturer()
            => new Manufacturer(brand: "Kawasaki", model: "Ninja 1000", year: 2017);

        protected override Engine BuildEngine()
            => new Engine(capacity: 1.0, power: 138, cylinders: 4, EngineType.Atmospheric, FuelType.Petrol);

        protected override Safety BuildSafety()
            => new Safety();

        protected override Transmission BuildTransmission()
            => new Transmission(gears: 6, TransmissionType.Manual, DriveType.RearWheelDrive);

        protected override Wheels BuildWheels()
            => new Wheels(count: 2, diameter: 17);
    }
}
