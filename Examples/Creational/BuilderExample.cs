using Patterns.Creational.Builder.Implementation;
using Patterns.Creational.Builder.Implementation.Builders;

namespace Examples.Creational
{
    public class BuilderExample
    {
        public void RunExample()
        {
            var bicycleFacility = new Facility<BicycleBuilder>();
            var motorbikeFacility = new Facility<MotorbikeBuilder>();
            var carFacility = new Facility<CarBuilder>();

            var bicycle = bicycleFacility.GetVehicle();
            var motorbike = motorbikeFacility.GetVehicle();
            var car = carFacility.GetVehicle();
        }
    }
}
