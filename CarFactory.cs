namespace LetsBuildACar
{
    public abstract class CarFactory
    {
        public abstract Body CreateBody();
        public abstract Powertrain CreatePowertrain();
        public abstract Interior CreateInterior();

        public abstract ElectricAndElectronics CreateElectricAndElectronics();
    }

    public class AmbassidorCarFactory : CarFactory
    {
        public override Body CreateBody()
        {
            return new AmbassadorBody();
        }

        public override Powertrain CreatePowertrain()
        {
            return new AmbassadorPowertrain();
        }

        public override Interior CreateInterior()
        {
            return new AmbassidorInterior();
        }

        public override ElectricAndElectronics CreateElectricAndElectronics()
        {
            return new AmbassadorElectricAndElectronics();
        }
    }


    public class FerrariAutomaticCarFactory : CarFactory
    {
        public override Body CreateBody()
        {
            return new FerrariBody();
        }

        public override Powertrain CreatePowertrain()
        {
            return new FerrariAutomaticPowertrain();
        }

        public override Interior CreateInterior()
        {
            return new FerrariInterior();
        }

        public override ElectricAndElectronics CreateElectricAndElectronics()
        {
            return new FerrariElectricAndElectronics();
        }
    }

    public class FerrariManualCarFactory : CarFactory
    {
        public override Body CreateBody()
        {
            return new FerrariBody();
        }

        public override Powertrain CreatePowertrain()
        {
            return new FerrariManualPowertrain();
        }

        public override Interior CreateInterior()
        {
            return new FerrariInterior();
        }

        public override ElectricAndElectronics CreateElectricAndElectronics()
        {
            return new FerrariElectricAndElectronics();

        }
    }
}