using Patterns.Creational.Builder.Auxilary.Components;
using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Abstraction
{
    public abstract class VehicleBuilder
    {
        public abstract VehicleType GetVehicleType();
        public abstract Manufacturer GetManufacturer();
        public abstract Engine GetEngine();
        public abstract Safety GetSafety();
        public abstract Transmission GetTransmission();
        public abstract Wheels GetWheels();
    }
}
