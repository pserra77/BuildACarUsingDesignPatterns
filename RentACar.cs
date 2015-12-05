using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LetsBuildACar
{
    public class RentACar
    {
        private readonly Car _carToRent;

        public RentACar(Car carToRent)
        {
            _carToRent = carToRent;
        }

        public void Rent(Customer customer, IVerifyDriverCredability carVerificationStrategy)
        {
            if (carVerificationStrategy.Verify(customer.Age, customer.LicenseNumber, _carToRent))
            {
                AssignCar();
            }

            else
            {
                throw new Exception("Sorry buddy. Seems like we cannot rent this car to you.");
            }
        }

        private void AssignCar()
        {
            //Assign Car to the Customer
        }
    }

    public class RentPermit
    {
        public string Name { get; set; }

        public static RentPermit Telangana;
        public static RentPermit AllIndia;

        static RentPermit()
        {
            Telangana = new RentPermit("Telengana");
            AllIndia = new RentPermit("AllIndia");
        }

        public RentPermit(string rentPermit)
        {
            Name = rentPermit;
        }
    }


    public class RentACarClient
    {
        public void Rent_A_Ferrari()
        {
            var carToRent = new Ferrari(new FerrariAutomaticCarFactory());
            var carRental = new RentACar(carToRent);
            var rentPermit = RentPermit.Telangana;

            var grandMa = new Customer() { Age = 87, LicenseNumber = "TS1235346" };

            var driverVerification = DriverVerification(rentPermit);

            carRental.Rent(grandMa, driverVerification);
        }


        /// <summary>
        /// This is by the way Factory Method
        /// </summary>
        /// <param name="rentPermit"></param>
        /// <returns></returns>
        private IVerifyDriverCredability DriverVerification(RentPermit rentPermit)
        {
            IVerifyDriverCredability driverVerification;

            if (rentPermit == RentPermit.Telangana)
            {
                driverVerification = new TelanganaCarVerification();
            }
            else
            {
                driverVerification = new AllIndiaCarVerification();
            }
            return driverVerification;
        }
    }
}
