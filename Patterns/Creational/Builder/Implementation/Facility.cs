using Patterns.Creational.Builder.Abstraction;

namespace Patterns.Creational.Builder.Implementation
{
    public class Facility<T> where T : VehicleBuilder, new()
    {
        public Vehicle GetVehicle()
        {
            var builder = new T();

            var type = builder.GetVehicleType();
            var manufacturer = builder.GetManufacturer();
            var engine = builder.GetEngine();
            var safety = builder.GetSafety();
            var transmission = builder.GetTransmission();
            var wheels = builder.GetWheels();

            return new Vehicle(type, manufacturer, engine, safety, transmission, wheels);
        }
    }
}
