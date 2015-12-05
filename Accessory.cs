namespace LetsBuildACar
{
    public abstract class Accessory
    {
        public double Price { get; set; }

        public string Name { get; set; }
    }

    public class TurboCharger : Accessory
    {
        public TurboCharger()
        {
            Name = "Turbo";
        }
    }

    public class Spoiler: Accessory
    {
        public string Color { get; set; }
        public Spoiler(string color)
        {
            Name = "Spoiler";
            Color = color;
        }
    }

    public class Fan : Accessory
    {
        public Fan()
        {
            Name = "Fan";
        }
    }
}