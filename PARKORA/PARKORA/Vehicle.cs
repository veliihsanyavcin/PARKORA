using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PARKORA
{
    public class Vehicle 
    {
        public string Plate { get; } //Aracın plaka verisinin tipi.
        public VehicleType Type { get; } //Aracımızın tipi için kullanılır.

        public Vehicle(String plate, VehicleType type )
        {
            this.Plate = plate;
            this.Type = type;
        }

        public void CheckPlate(MaskedTextBox textBox) //Girilen plaka için kontrol yaptığımız metod.
        {
            if (!textBox.MaskFull)
            {

                throw new SyntaxErrorException();
            }

            string sehirKodu = textBox.Text.Substring(0, 2);

            if (Convert.ToByte(sehirKodu) > 81 || Convert.ToByte(sehirKodu) < 1)
            {

                throw new SyntaxErrorException();
            }

            //Regex top = new Regex("^[8-9][2-9]");
            //Regex zero = new Regex("^[0][0]");
            //Regex r = new Regex("^\\d{2}-\\w{1,3}-\\d{2,4}$");

            //if (!r.IsMatch(Plate) || zero.IsMatch(Plate) || top.IsMatch(Plate))
            //{
                
            //}
        }
    }
}
