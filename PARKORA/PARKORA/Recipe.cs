using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARKORA
{
   public class Recipe
    {
        public double Period { get; } //Çıkış yapan araçların otopark ücretlendirmesi yapılırken kullanılan veri tipi.

        public double Cost { get; } //Otoprakımızdan çıkış yapan araçların ödedeği ücretlerin toplamın hesaplanması için kullandığımız veri tipi.

        public Recipe(double period, double cost)
        {
            this.Cost = cost;
            this.Period = period;
        }
    }
}
