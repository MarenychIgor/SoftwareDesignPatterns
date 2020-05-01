using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Implementation;

namespace Patterns.Creational.Builder.Abstraction
{
    public abstract class VehicleBuilder
    {
        public abstract Vehicle Build();

        protected abstract Manufacturer BuildManufacturer();
        protected abstract Engine BuildEngine();
        protected abstract Safety BuildSafety();
        protected abstract Transmission BuildTransmission();
        protected abstract Wheels BuildWheels();
    }
}
