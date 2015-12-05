using System;

namespace LetsBuildACar
{
    public abstract class BreakingSystem
    {
        public abstract void ApplyBreaks();

        public abstract void Accelerate();

        public abstract void Decelerate();
    }

    public class BreakingSystemWithABS : BreakingSystem
    {
        public override void ApplyBreaks()
        {
            throw new NotImplementedException();
        }

        public override void Accelerate()
        {
            throw new NotImplementedException();
        }

        public override void Decelerate()
        {
            throw new NotImplementedException();
        }
    }

    public class NormalBreakingSystem : BreakingSystem
    {
        public override void ApplyBreaks()
        {
            throw new NotImplementedException();
        }

        public override void Accelerate()
        {
            throw new NotImplementedException();
        }

        public override void Decelerate()
        {
            throw new NotImplementedException();
        }
    }
}