using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARKORA
{
   public class Slot
    {
        private int Capacity;
        private List<Recipe> RecipeList; //Araçların ücret tarifesi listesi.
        private List<Ticket> TicketList; //Giriş-Çıkış yapan araçların listesi.

        public Slot(int Capacity, List<Recipe> recipeList)
        {
            this.TicketList = new List<Ticket>();
            this.RecipeList = recipeList;
        }

        public void SlotIn(Vehicle vehicle) //
        {

        }

        public void SlotOut(string plate) //
        {

        }

        public List<Ticket> GetSlotIn()//Giriş yapan araçların listesinin tutulduğu metod.
        {
            return TicketList;
        }


        public List<Ticket> GetSlotOut()//Çıkış yapan araçların listesinin tutulduğu metod.
        {
            return TicketList;
        }

        private bool IsEmpty()//Araçlarımız için yer kontrolünün sağlandığı meytod.
        {
            return this.Capacity - TicketList.Count > 0;
        }

        private bool IsAlreadyIn(string plate)//Plaka kontrolünün sağlandığı listede olup-olmadığının kontrol edildiği metod.
        {
            return true;
        }

        private double CalcPayment(Ticket ticket)//Ödeme
        {
            return 0;
        }
    }
}
