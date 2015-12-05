using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LetsBuildACar
{
    public abstract class DriveCar
    {
        protected abstract void StartEngine();
        protected abstract void ChangeGear(int speed, Direction direction);
        protected abstract void ApplyAccelator();
        protected abstract void StopAccelaration();
        protected abstract void BringToNeutral();
        protected abstract void StopEngine();

        public void Drive()
        {
            StartEngine();
            ChangeGear(1, Direction.Forward);
            ApplyAccelator();
        }

        public void Stop()
        {
            StopAccelaration();
            BringToNeutral();
            StopEngine();
        }
    }

    public class DriveFerrari : DriveCar
    {
        private readonly Ferrari _ferrari;

        public DriveFerrari(Ferrari ferrari)
        {
            _ferrari = ferrari;
        }

        protected override void StartEngine()
        {
            _ferrari.HitStartButton();
        }

        protected override void ChangeGear(int speed, Direction direction)
        {
            _ferrari.ChangeGears(0, direction);
        }

        protected override void ApplyAccelator()
        {
            _ferrari.Accelerate();
        }

        protected override void StopAccelaration()
        {
            _ferrari.Decelerate();
        }

        protected override void BringToNeutral()
        {
            _ferrari.ChangeGears(0, Direction.Neutral);
        }

        protected override void StopEngine()
        {
            _ferrari.HitStopButton();
        }
    }

    public class DriveAmbassador : DriveCar
    {
        private readonly Ambassador _ambassador;

        public DriveAmbassador(Ambassador ambassador)
        {
            _ambassador = ambassador;
        }

        protected override void StartEngine()
        {
            if (false == _ambassador.IgnitionOn())
            {
                //Try again

                if (false == _ambassador.IgnitionOn())
                {
                    _ambassador.ChokeUntilDeath();

                    if (false == _ambassador.IgnitionOn())
                    {
                        throw new Exception("Sorry I cannot start!!!! Get some people to push the car!!!");
                    }
                }
            }
        }

        protected override void ChangeGear(int speed, Direction direction)
        {
            _ambassador.ChangeGears(1, Direction.Forward);
        }

        protected override void ApplyAccelator()
        {
            _ambassador.Accelerate();
        }

        protected override void StopAccelaration()
        {
            _ambassador.Decelerate();
        }

        protected override void BringToNeutral()
        {
            _ambassador.ChangeGears(0, Direction.Neutral);
        }

        protected override void StopEngine()
        {
            _ambassador.IgnitionOff();
        }
    }


    public class Client
    {
        public void Drive_AFerrai_Automatic()
        {
            var ferrari = new Ferrari(new FerrariAutomaticCarFactory());
            var driveFerrari = new DriveFerrari(ferrari);
            driveFerrari.Drive();
            driveFerrari.Stop();
        }

        public void Drive_An_Ambassador()
        {
            var ambazador = new Ambassador(new AmbassidorCarFactory());
            var driveAmbazador = new DriveAmbassador(ambazador);
            driveAmbazador.Drive();
            driveAmbazador.Stop();
        }
    }
}
