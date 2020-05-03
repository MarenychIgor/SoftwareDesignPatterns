using Patterns.Creational.Builder.Abstraction;
using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;
using System;

namespace Patterns.Creational.Builder.Implementation.Builders
{
    /// <summary>
    /// The 'ConcreteBuilder' class.
    /// Constructs and assembles parts of the product by implementing the <see cref="VehicleBuilder"/> interface.
    /// Defines and keeps track of the representation it creates.
    /// Provides an interface for retrieving the <see cref="Vehicle"/>.
    /// </summary>
    public class BicycleBuilder : VehicleBuilder
    {
        public override void BuildType()
            => vehicle.Type = VehicleType.Bicycle;

        public override void BuildManufacturer()
            => vehicle.Manufacturer = new Manufacturer(brand: "BMX", model: "Street", year: 1992);

        public override void BuildEngine()
            => throw new InvalidOperationException($"{nameof(VehicleType.Bicycle)} can't have {nameof(Engine)}");

        public override void BuildSafety()
            => throw new InvalidOperationException($"{nameof(VehicleType.Bicycle)} can't have {nameof(Safety)}");

        public override void BuildTransmission()
            => throw new InvalidOperationException($"{nameof(VehicleType.Bicycle)} can't have {nameof(Transmission)}");

        public override void BuildWheels()
            => vehicle.Wheels = new Wheels(count: 2, diameter: 20);
    }
}
