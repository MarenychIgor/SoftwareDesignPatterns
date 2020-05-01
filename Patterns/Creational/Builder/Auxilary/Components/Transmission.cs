using Patterns.Creational.Builder.Auxilary.Enums;

namespace Patterns.Creational.Builder.Auxilary.Components
{
    public class Transmission
    {
        public int Gears { get; private set; }
        public TransmissionType Type { get; private set; }
        public DriveType Drive { get; private set; }

        public Transmission()
        {
            Gears = default;
            Type = TransmissionType.None;
            Drive = DriveType.RearWheelDrive;
        }

        public Transmission(int gears, TransmissionType transmission, DriveType drive)
        {
            Gears = gears;
            Type = transmission;
            Drive = drive;
        }
    }
}
