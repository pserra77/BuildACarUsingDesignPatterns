namespace LetsBuildACar
{
    public interface IVerifyDriverCredability
    {
        bool Verify(int age, string licenseNumber, Car carToRent);
    }

    public class TelanganaCarVerification : IVerifyDriverCredability
    {
        public bool Verify(int age, string licenseNumber, Car carToRent)
        {
            if (!carToRent.CanIDriveThisCar(age))
            {
                return false;
            }
            
            return VerifyWithRTA(licenseNumber);
        }

        private bool VerifyWithRTA(string licenseNumber)
        {
            //Verify with RTA implementation

            return true;
        }
    }

    public class AllIndiaCarVerification : IVerifyDriverCredability
    {
        public bool Verify(int age, string licenseNumber, Car carToRent)
        {
            if (!carToRent.CanIDriveThisCar(age))
            {
                return false;
            }

            return VerifyWithRTA(licenseNumber);
        }

        private bool VerifyWithRTA(string licenseNumber)
        {
            //Verify with RTA implementation
            return false;
        }
    }
}