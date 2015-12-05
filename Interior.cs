using System.Runtime.InteropServices;

namespace LetsBuildACar
{
    public class AudioVideoComponent
    {
    }

    public class AppleSmartAV : AudioVideoComponent
    {
    }

    public class CentralConsole
    {
    }

    public class SmartCentralConsole : CentralConsole
    {
    }

    public class Seats
    {
        public int Capacity { get; set; }

        public Seats()
        {
            Capacity = 4;
        }
    }

    class FerrariSeats : Seats
    {
        public int SeatHeightCentimeters { get; set; }

        public FerrariSeats()
        {
            Capacity = 2;
        }

        public void AdjustHeight(int height)
        {
            SeatHeightCentimeters = height;
        }
    }

    public class FerrariSmartConsole : CentralConsole
    {
    }

    public class Ignition
    {
    }

    public class Wheels
    {
    }

    public abstract class Interior
    {
        public Seats Seats { get; set; }
        public CentralConsole CentralConsole { get; set; }
        public AudioVideoComponent AudioVideoComponent { get; set; }
    }

    public class AmbassidorInterior : Interior
    {
        public AmbassidorInterior()
        {
            Seats = new Seats();
            CentralConsole = new SmartCentralConsole();
            AudioVideoComponent = new AudioVideoComponent();
        }
    }
    
    public class FerrariInterior : Interior
    {
        public FerrariInterior()
        {
            Seats = new FerrariSeats();
            CentralConsole = new FerrariSmartConsole();
            AudioVideoComponent = new AppleSmartAV();
        }

        public void AnswerPhone()
        {
        }
    }
}