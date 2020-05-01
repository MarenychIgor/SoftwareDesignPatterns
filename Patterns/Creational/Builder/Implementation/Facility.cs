using Patterns.Creational.Builder.Abstraction;

namespace Patterns.Creational.Builder.Implementation
{
    public class Facility<T> where T : VehicleBuilder, new()
    {
        public Vehicle GetVehicle()
        {
            var builder = new T();
            return builder.Build();
        }
    }
}
