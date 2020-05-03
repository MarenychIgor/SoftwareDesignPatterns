using Patterns.Creational.Builder.Abstraction;
using Patterns.Creational.Builder.Implementation.Builders;
using System;

namespace Patterns.Creational.Builder.Implementation
{
    /// <summary>
    /// The 'Director' class
    /// Constructs an object using the <see cref="VehicleBuilder"/> interface.
    /// </summary>
    public class Facility 
    { 
        public Vehicle Construct(VehicleBuilder builder)
            => builder switch
            {
                BicycleBuilder bicycleBuilder => GetBicycle(bicycleBuilder),
                CarBuilder carBuilder => GetCar(carBuilder),
                MotorbikeBuilder motorbikeBuilder => GetMotorbike(motorbikeBuilder),
                _ => throw new ArgumentException($"Builder type {builder.GetType().Name} is not supported")
            };

        private Vehicle GetBicycle(BicycleBuilder builder)
        {
            builder.BuildType();
            builder.BuildManufacturer();
            builder.BuildWheels();

            return builder.GetResult();
        }

        private Vehicle GetCar(CarBuilder builder)
        {
            builder.BuildType();
            builder.BuildManufacturer();
            builder.BuildEngine();
            builder.BuildSafety();
            builder.BuildTransmission();
            builder.BuildWheels();

            return builder.GetResult();
        }

        private Vehicle GetMotorbike(MotorbikeBuilder builder)
        {
            builder.BuildType();
            builder.BuildManufacturer();
            builder.BuildEngine();
            builder.BuildTransmission();
            builder.BuildWheels();

            return builder.GetResult();
        }
    }
}
