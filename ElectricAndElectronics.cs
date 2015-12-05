namespace LetsBuildACar
{
    public abstract class ElectricAndElectronics
    {
        protected int CurrentSpeed { get; set; }

        public abstract Signal IgnitionOn();
        public abstract Signal IgnitionOff();

        public abstract void LightOn();
        public abstract void LightOff();

        public int GetSpeed()
        {
            return CurrentSpeed;
        }

        public void SetSpeed(int speed)
        {
            CurrentSpeed = speed;
        }

        public void IncreaseSpeed(int speedIncrease)
        {
            CurrentSpeed += speedIncrease;
        }

        public void DecreaseSpeed(int speedDecrease)
        {
            CurrentSpeed -= speedDecrease;
        }
    }

    class AmbassadorElectricAndElectronics : ElectricAndElectronics
    {
        public override Signal IgnitionOn()
        {
            return new EngineOnSignal();
        }

        public override Signal IgnitionOff()
        {
            return new EngineOffSignal();
        }

        public override void LightOn()
        {
            throw new System.NotImplementedException();
        }

        public override void LightOff()
        {
            throw new System.NotImplementedException();
        }
    }

    


    public class FerrariElectricAndElectronics : ElectricAndElectronics
    {
        public override Signal IgnitionOn()
        {
            throw new System.NotImplementedException();
        }

        public override Signal IgnitionOff()
        {
            throw new System.NotImplementedException();
        }

        public override void LightOn()
        {
            throw new System.NotImplementedException();
        }

        public override void LightOff()
        {
            throw new System.NotImplementedException();
        }
    }

    
}