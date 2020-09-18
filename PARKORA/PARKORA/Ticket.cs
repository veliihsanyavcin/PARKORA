using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARKORA
{
   public class Ticket
    {
        private string Plate { get; }

        private Type VehicleType { get; }

        private DateTime TimeIn { get; } //Giriş zamanı için kullanılır.

        private Ticket(string Plate, Type VehicleType, DateTime TimeIn)
        {
            this.Plate = Plate;
            this.VehicleType = VehicleType;
            this.TimeIn = TimeIn;
        }

        private DateTime TimeOut { get; set; }//Çıkış zamanı için kullanılır.

        private double Cost { get; set; }
    }
}
