using Patterns.Creational.Builder.Abstraction;
using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;
using System;

namespace Patterns.Creational.Builder.Implementation.Builders
{
    /// <summary>
    /// The 'ConcreteBuilder' class.
    /// Constructs and assembles parts of the product by implementing the 'Builder' interface.
    /// Defines and keeps track of the representation it creates.
    /// Provides an interface for retrieving the 'Product'.
    /// </summary>
    public class MotorbikeBuilder : VehicleBuilder
    {
        public override void BuildType()
            => vehicle.Type = VehicleType.Motorbike;

        public override void BuildManufacturer()
            => vehicle.Manufacturer = new Manufacturer(brand: "Kawasaki", model: "Ninja 1000", year: 2017);

        public override void BuildEngine()
            => vehicle.Engine = new Engine(capacity: 1.0, power: 138, cylinders: 4, EngineType.Atmospheric, FuelType.Petrol);

        public override void BuildSafety()
            => throw new InvalidOperationException($"{nameof(VehicleType.Motorbike)} can't have {nameof(Safety)}");

        public override void BuildTransmission()
            => vehicle.Transmission = new Transmission(gears: 6, TransmissionType.Manual, DriveType.RearWheelDrive);

        public override void BuildWheels()
            => vehicle.Wheels = new Wheels(count: 2, diameter: 17);
    }
}
