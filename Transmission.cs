namespace LetsBuildACar
{

    public class TransmissionType
    {
        public string Name { get; set; }
        public int NumberOfGears { get; set; }

        public static TransmissionType Automatic;
        public static TransmissionType Manual;

        static TransmissionType()
        {
            Automatic = new TransmissionType("Automatic");
            Manual = new TransmissionType("Manual");
        }

        public TransmissionType(string transmissionType)
        {
            Name = transmissionType;
        }
    }

    public abstract class Transmission
    {
        public TransmissionType TransmissionType { get; set; }

        public int NumberofGears { get; set; }

        public abstract void ChangeGear(int speed, Direction direction);
    }


    public class FerrariManualTransmission : Transmission
    {
        public int CurrentGear { get; protected set; }

        public FerrariManualTransmission()
        {
            TransmissionType = TransmissionType.Manual;
            NumberofGears = 6;
        }

        private void ChangeGearInternal(int gearNumber)
        {
            CurrentGear = gearNumber;
        }

        public override void ChangeGear(int speed, Direction direction)
        {
            if (direction == Direction.Reverse)
            {
                ChangeGearInternal(-1);
                return;
            }

            if (direction == Direction.Neutral)
            {
                ChangeGearInternal(0);
                return;
            }

            if (speed <= 20)
            {
                ChangeGearInternal(1);
            }
            else if (speed > 20 && speed <= 40)
            {
                ChangeGearInternal(2);
            }
            else if (speed > 40 && speed <= 60)
            {
                ChangeGearInternal(3);
            }
            else if (speed > 60 && speed <= 100)
            {
                ChangeGearInternal(4);
            }
            else if (speed > 100)
            {
                ChangeGearInternal(5);
            }
            else
            {
                ChangeGearInternal(6);
            }
        }
    }

    public class FerrariAutomaticTransmission : Transmission
    {
        public char CurrentDriveMode { get; set; }

        public FerrariAutomaticTransmission()
        {
            TransmissionType = TransmissionType.Automatic;
            NumberofGears = 8;
        }

        private void SetDriveMode(char driveMode)
        {
            CurrentDriveMode = driveMode;
        }

        public override void ChangeGear(int speed, Direction direction)
        {
            if (direction == Direction.Reverse)
            {
                SetDriveMode('R');
            }
            else if (direction == Direction.Neutral)
            {
                SetDriveMode('N');
            }
            else if(direction == Direction.Forward)
            {
                SetDriveMode('D');
            }
        }
    }

    public class AmbassadorTransmission : Transmission
    {
        public int CurrentGear { get; protected set; }
        
        private void ChangeGearInternal(int gearNumber)
        {
            CurrentGear = gearNumber;
        }

        public override void ChangeGear(int speed, Direction direction)
        {
            if (direction == Direction.Reverse)
            {
                ChangeGearInternal(-1);
                return;
            }

            if (direction == Direction.Neutral)
            {
                ChangeGearInternal(0);
                return;
            }

            if (speed <= 20)
            {
                ChangeGearInternal(1);
            }
            else if (speed > 20 && speed <= 40)
            {
                ChangeGearInternal(2);
            }
            else if (speed > 40 && speed <= 60)
            {
                ChangeGearInternal(3);
            }
            else if (speed > 60)
            {
                ChangeGearInternal(4);
            }
        }
    }
}