namespace LetsBuildACar
{
    public abstract class Signal
    {
        public int Current { get; set; }
    }

    class EngineOnSignal : Signal
    {
        public EngineOnSignal()
        {
            Current = 11;
        }
    }

    class EngineOffSignal : Signal
    {
        public EngineOffSignal()
        {
            Current = 12;
        }
    }

    class AccelarateSignal : Signal
    {
        public AccelarateSignal()
        {
            Current = 21;
        }
    }

    class DecelerateSignal : Signal
    {
        public DecelerateSignal()
        {
            Current = 22;
        }
    }
}