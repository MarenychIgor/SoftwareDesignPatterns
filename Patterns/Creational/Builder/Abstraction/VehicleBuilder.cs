using Patterns.Creational.Builder.Implementation;

namespace Patterns.Creational.Builder.Abstraction
{
    /// <summary>
    /// The 'Builder' abstract class.
    /// Specifies interface for creating parts of a <see cref="Vehicle"/> object.
    /// </summary>
    public abstract class VehicleBuilder
    {
        protected Vehicle vehicle = new Vehicle();

        public abstract void BuildType();
        public abstract void BuildManufacturer();
        public abstract void BuildEngine();
        public abstract void BuildSafety();
        public abstract void BuildTransmission();
        public abstract void BuildWheels();

        public Vehicle GetResult()
            => vehicle;
    }
}
