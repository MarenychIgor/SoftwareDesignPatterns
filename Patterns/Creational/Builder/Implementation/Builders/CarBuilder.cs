using Patterns.Creational.Builder.Abstraction;
using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Implementation.Builders
{
    public class CarBuilder : VehicleBuilder
    {
        public override VehicleType GetVehicleType()
            => VehicleType.Car;

        public override Manufacturer GetManufacturer()
            => new Manufacturer(brand: "Toyota", model: "Camry", year: 2014);

        public override Engine GetEngine()
            => new Engine(capacity: 2.5, power: 181, cylinders: 4, EngineType.Atmospheric, FuelType.Petrol);

        public override Safety GetSafety()
            => new Safety(airbags: 9);

        public override Transmission GetTransmission()
            => new Transmission(gears: 6, TransmissionType.Automatic, DriveType.FrontWheelDrive);

        public override Wheels GetWheels()
            => new Wheels(count: 4, diameter: 17);
    }
}
