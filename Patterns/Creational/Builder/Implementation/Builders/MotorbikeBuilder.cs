using Patterns.Creational.Builder.Abstraction;
using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Implementation.Builders
{
    public class MotorbikeBuilder : VehicleBuilder
    {
        public override VehicleType GetVehicleType()
            => VehicleType.Motorbike;

        public override Manufacturer GetManufacturer()
            => new Manufacturer(brand: "Kawasaki", model: "Ninja 1000", year: 2017);

        public override Engine GetEngine()
            => new Engine(capacity: 1.0, power: 138, cylinders: 4, EngineType.Atmospheric, FuelType.Petrol);

        public override Safety GetSafety()
            => new Safety();

        public override Transmission GetTransmission()
            => new Transmission(gears: 6, TransmissionType.Manual, DriveType.RearWheelDrive);

        public override Wheels GetWheels()
            => new Wheels(count: 2, diameter: 17);
    }
}
