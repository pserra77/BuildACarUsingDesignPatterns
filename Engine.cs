namespace LetsBuildACar
{
    public class EngineVariant
    {
        public string Name { get; private set; }

        public static EngineVariant Petrol;
        public static EngineVariant Diesel;

        static EngineVariant()
        {
            Petrol = new EngineVariant("Petrol");
            Diesel = new EngineVariant("Diesel");
        }

        public EngineVariant(string variantName)
        {
            Name = variantName;
        }
    }

    public abstract class Engine
    {
        public int Capacity { get; set; }
        public int Cylinders { get; set; }
        public EngineVariant EngineVariant { get; set; }

        public abstract void StartEngine();

        public virtual void CrankUp()
        {
            // Increase Intake of Air
            // Compress Air
            // Increase Power
            // Exhaust
        }

        public virtual void CrankDown()
        {
            // Increase Intake of Air
            // Compress Air
            // Increase Power
            // Exhaust
        }
    }

    public class AmbassadorEngine : Engine
    {
        public AmbassadorEngine()
        {
            Capacity = 1500;
            Cylinders = 4;
            EngineVariant = EngineVariant.Diesel;
        }

        public override void StartEngine()
        {
            //Start the engine here.
        }

        public override void CrankUp()
        {
            base.CrankUp();

            //Crank up the Ambazador engine
        }
    }

    public class FerrariEngine : Engine
    {
        public FerrariEngine()
        {
            Capacity = 3000;
            Cylinders = 8;
            EngineVariant = EngineVariant.Petrol;
        }

        public override void StartEngine()
        {
            //Start engine here
        }
    }
}