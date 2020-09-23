using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARKORA
{
    public class Ticket
    {
        public Vehicle Vehicle { get; }

        public DateTime TimeIn { get; } //Giriş zamanı için kullanılır.

        public DateTime TimeOut { get; set; } //Çıkış zamanı için kullanılır.

        public double Cost { get; set; }

        public Ticket(Vehicle vehicle, DateTime TimeIn)
        {
            this.Vehicle = vehicle;
            this.TimeIn = TimeIn;
        }
    }
}
