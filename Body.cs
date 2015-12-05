using System;

namespace LetsBuildACar
{
    public abstract class Body
    {
        protected abstract Ignition Ignition { get; set; }
        protected abstract Wheels Wheels { get; set; }
    }

    public class AmbassadorBody : Body
    {
        protected override Ignition Ignition { get; set; }
        protected override Wheels Wheels { get; set; }
    }

    public class FerrariBody : Body
    {
        protected override Ignition Ignition { get; set; }
        protected override Wheels Wheels { get; set; }

        public FerrariBody()
        {

        }
    }
}