using System;
using System.CodeDom;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LetsBuildACar
{
    public abstract class Car
    {
        public Body Body { get; protected set; }
        public Powertrain Powertrain { get; protected set; }
        public Interior Interior { get; protected set; }
        public ElectricAndElectronics ElectricAndElectronics { get; protected set; }

        public void ChangeGears(int speed, Direction direction)
        {
            Powertrain.ChangeGears(speed, direction);
        }

        public void Accelerate()
        {
            Powertrain.Accelerate();
            ElectricAndElectronics.IncreaseSpeed(10);
        }

        public void Decelerate()
        {
            Powertrain.Decelerate();
            ElectricAndElectronics.DecreaseSpeed(10);
        }

        public abstract bool CanIDriveThisCar(int age);
    }

    public sealed class Ambassador : Car
    {
        public Ambassador(CarFactory factory)
        {
            Body = factory.CreateBody();
            Powertrain = factory.CreatePowertrain();
            Interior = factory.CreateInterior();
            ElectricAndElectronics = factory.CreateElectricAndElectronics();
        }

        public bool IgnitionOn()
        {
            var prob = new Random().Next(100);
            var doesOn = prob < 20;

            if (doesOn)
            {
                var signal = ElectricAndElectronics.IgnitionOn();
                Powertrain.PushSignal(signal);
            }

            return doesOn;
        }

        public void ChokeUntilDeath()
        {
            //Apply Choke
        }

        public void IgnitionOff()
        {
        }

        public override bool CanIDriveThisCar(int age)
        {
            if (age > 20 && age < 80)
            {
                return true;
            }

            return false;
        }
    }

    public sealed class Ferrari : Car
    {
        public Ferrari(CarFactory factory)
        {
            Body = factory.CreateBody();
            Powertrain = factory.CreatePowertrain();
            Interior = factory.CreateInterior();
            ElectricAndElectronics = factory.CreateElectricAndElectronics();
        }
        public void HitStartButton()
        {
            Signal signal = ElectricAndElectronics.IgnitionOn();
            Powertrain.PushSignal(signal);
        }

        public void HitStopButton()
        {
            Signal signal = ElectricAndElectronics.IgnitionOff();
            Powertrain.PushSignal(signal);
        }

        public override bool CanIDriveThisCar(int age)
        {
            if (age > 20 && age < 55)
            {
                return true;
            }

            return false;
        }
    }
}
