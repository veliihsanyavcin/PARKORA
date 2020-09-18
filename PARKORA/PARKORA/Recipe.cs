using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARKORA
{
   public class Recipe
    {
        private double Period; //Çıkış yapan araçların otopark ücretlendirmesi yapılırken kullanılan veri tipi.

        private double Cost; //Otoprakımızdan çıkış yapan araçların ödedeği ücretlerin toplamın hesaplanması için kullandığımız veri tipi.

        public Recipe(double period, double cost)
        {
            this.Cost = cost;
            this.Period = period;
        }

        private double GetPeriod()
        {
            return Period;

        }

        private double GetCost()
        {
            return Cost;
        }
    }
}
