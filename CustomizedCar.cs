using System.Collections.Generic;

namespace LetsBuildACar
{
    public class CustomizedCar : Car
    {
        private readonly Car _thisCar;
        private readonly IList<Accessory> _accessories; 

        public CustomizedCar(Car car)
        {
            _thisCar = car;
            _accessories = new List<Accessory>();
        }

        public void AddAccessory(Accessory accessory)
        {
            _accessories.Add(accessory);
        }

        public override bool CanIDriveThisCar(int age)
        {
            return _thisCar.CanIDriveThisCar(age);
        }
    }
}