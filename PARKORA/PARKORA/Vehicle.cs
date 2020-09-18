using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARKORA
{
    public class Vehicle
    {
        private string Plate; //Aracın plaka verisinin tipi.
        private VehicleType Type; //Aracımızın tipi için kullanılır.

        public void CheckPlate() //Girilen plaka için kontrol yaptığımız metod.
        {
            // todo: plaka kontrol metodu eklenecek
        }

        public VehicleType GetType()
        {
            return Type;
        }

        public string GetPlate()
        {
            return Plate;
        }
    }
}
