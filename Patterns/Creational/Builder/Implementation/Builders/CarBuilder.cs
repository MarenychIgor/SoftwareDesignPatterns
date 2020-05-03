using Patterns.Creational.Builder.Abstraction;
using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Implementation.Builders
{
    /// <summary>
    /// The 'ConcreteBuilder' class.
    /// Constructs and assembles parts of the product by implementing the 'Builder' interface.
    /// Defines and keeps track of the representation it creates.
    /// Provides an interface for retrieving the 'Product'.
    /// </summary>
    public class CarBuilder : VehicleBuilder
    {
        public override void BuildType()
            => vehicle.Type = VehicleType.Car;

        public override void BuildManufacturer()
            => vehicle.Manufacturer = new Manufacturer(brand: "Toyota", model: "Camry", year: 2014);

        public override void BuildEngine()
            => vehicle.Engine = new Engine(capacity: 2.5, power: 181, cylinders: 4, EngineType.Atmospheric, FuelType.Petrol);

        public override void BuildSafety()
            => vehicle.Safety = new Safety(airbags: 9);

        public override void BuildTransmission()
            => vehicle.Transmission = new Transmission(gears: 6, TransmissionType.Automatic, DriveType.FrontWheelDrive);

        public override void BuildWheels()
            => vehicle.Wheels = new Wheels(count: 4, diameter: 17);
    }
}
