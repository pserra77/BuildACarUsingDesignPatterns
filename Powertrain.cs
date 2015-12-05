namespace LetsBuildACar
{
    public class Direction
    {
        public string Name { get; private set; }

        public static Direction Forward;
        public static Direction Reverse;
        public static Direction Neutral;

        static Direction()
        {
            Forward = new Direction("Forward");
            Reverse = new Direction("Reverse");
            Neutral = new Direction("Neutral");
        }

        public Direction(string variantName)
        {
            Name = variantName;
        }
    }

    public abstract class Powertrain
    {
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public BreakingSystem BreakingSystem { get; set; }

        public void ChangeGears(int speed, Direction direction)
        {
            Transmission.ChangeGear(speed, direction);
        }

        public void Accelerate()
        {
            Engine.CrankUp();

           
        }

        public void Decelerate()
        {
            Engine.CrankDown();
        }

        public void PushSignal(Signal signal)
        {
            if (signal.Current == 11)
            {
                //Do the thing that gets the engine crank up
            }
        }
    }

    public class FerrariManualPowertrain : Powertrain
    {
        public FerrariManualPowertrain()
        {
            Engine = new FerrariEngine();
            Transmission = new FerrariManualTransmission();
        }
    }

    public class FerrariAutomaticPowertrain : Powertrain
    {
        public FerrariAutomaticPowertrain()
        {
            Engine = new FerrariEngine();
            Transmission = new FerrariAutomaticTransmission();
            BreakingSystem = new NormalBreakingSystem();
        }
    }

    public class AmbassadorPowertrain : Powertrain
    {
        public AmbassadorPowertrain()
        {
            Engine = new AmbassadorEngine();
            Transmission = new AmbassadorTransmission();
            BreakingSystem = new NormalBreakingSystem();
        }
    }
}