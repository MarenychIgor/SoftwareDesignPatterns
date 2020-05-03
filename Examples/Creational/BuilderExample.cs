using Patterns.Creational.Builder.Implementation;
using Patterns.Creational.Builder.Implementation.Builders;

namespace Examples.Creational
{
    public class BuilderExample
    {
        public void RunExample()
        {
            var facility = new Facility();

            var bicycle = facility.Construct(new BicycleBuilder());
            var motorbike = facility.Construct(new MotorbikeBuilder());
            var car = facility.Construct(new CarBuilder());
        }
    }
}
