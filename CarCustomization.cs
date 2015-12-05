using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBuildACar
{
    public class CustomizeMyCar
    {
        public Car Make_A_Customized_Ambi_For_MrSimson()
        {

            //Make_A_Customized_Ambi_For_MrSimson Ambassidor
            var mrSimsonsAmbi = new Ambassador(new AmbassidorCarFactory());
            var mrSimsonsCustomAmbi = new CustomizedCar(mrSimsonsAmbi);
            mrSimsonsCustomAmbi.AddAccessory(new TurboCharger());
            mrSimsonsCustomAmbi.AddAccessory(new Fan());

            return mrSimsonsAmbi;

        }

        public Car Make_A_Customized_Ferrari_For_SuperMan()
        {
            //Make_A_Customized_Ambi_For_MrSimson Ferrari
            var superMansFerrari = new Ferrari(new FerrariManualCarFactory());
            var superMansCustomFerrari = new CustomizedCar(superMansFerrari);
            superMansCustomFerrari.AddAccessory(new TurboCharger());
            superMansCustomFerrari.AddAccessory(new Spoiler("Blue"));

            return superMansFerrari;
        }
    }
}
