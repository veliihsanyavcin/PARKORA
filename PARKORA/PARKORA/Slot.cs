using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARKORA
{
    public class Slot
    {
        private int Capacity;
        private List<Recipe> RecipeList; //Araçların ücret tarifesi listesi.
        private List<Ticket> TicketList; //Giriş-Çıkış yapan araçların listesi.

        public Slot(int capacity, List<Recipe> recipeList)
        {
            this.Capacity = capacity;
            this.TicketList = new List<Ticket>();
            this.RecipeList = recipeList;
        }

        public void SlotIn(Vehicle vehicle)
        {

            if (!IsEmpty())
            {
                MessageBox.Show("OTOPARK DOLU");
                return;
            }

            if (IsAlreadyIn(vehicle.Plate))
            {
                MessageBox.Show("ARAÇ İÇERDE");
                return;
            }

            Ticket NewTicket = new Ticket(vehicle, DateTime.Now);
            this.TicketList.Add(NewTicket);

        }

        public void SlotOut(string plate) //
        {
            int index = TicketList.FindIndex(x => x.Vehicle.Plate == plate);
            TicketList[index].TimeOut = DateTime.Now;
            double cost = CalcPayment(TicketList[index]);
            TicketList[index].Cost = cost;
            MessageBox.Show("Tutar:" + cost.ToString(), "Ücretiniz");
        }

        public List<Ticket> GetSlotIn() //Giriş yapan araçların listesinin tutulduğu metod.
        {
            return TicketList.FindAll(x => x.TimeOut == DateTime.MinValue);
        }

        public List<Ticket> GetSlotOut() //Çıkış yapan araçların listesinin tutulduğu metod.
        {
            return TicketList.FindAll(x => x.TimeOut != null);
        }

        private bool IsEmpty() //Araçlarımız için yer kontrolünün sağlandığı meytod.
        {

            return this.Capacity - GetSlotIn().Count > 0;
        }

        private bool
            IsAlreadyIn(string plate) //Plaka kontrolünün sağlandığı listede olup-olmadığının kontrol edildiği metod.
        {
            return GetSlotIn().Exists(x => x.Vehicle.Plate == plate);
        }

        private double CalcPayment(Ticket ticket) //Ödeme
        {


            TimeSpan fark = ticket.TimeOut - ticket.TimeIn;
            double saniye = fark.TotalSeconds;

            RecipeList.Sort((x, y) => (int)(x.Period - y.Period));
            var maxPeriod = RecipeList[RecipeList.Count - 1].Period;

            double totalCost = 0;
            double remaininSecond = saniye;
            double currentPeriodCost = 0;
            Recipe previousRecipe = null;

            for (int i = 0; i < Math.Ceiling(saniye / maxPeriod); i++)
            {
                currentPeriodCost = 0d;

                RecipeList.ForEach(recipe =>
                {
                    if (previousRecipe != null && previousRecipe.Period < remaininSecond &&
                        remaininSecond <= recipe.Period)
                    {
                        currentPeriodCost = recipe.Cost;
                    }
                    else if (remaininSecond >= recipe.Period)
                    {
                        currentPeriodCost = recipe.Cost;
                    }

                    previousRecipe = recipe;
                });
                totalCost += currentPeriodCost;
                remaininSecond -= maxPeriod;
            }

            return totalCost;
            //}
        }

        //private double CalcPayment(Ticket ticket) //Ödeme
        //{
        //    TimeSpan fark = ticket.TimeOut - ticket.TimeIn;
        //    double saniye = fark.TotalSeconds;

        //    RecipeList.Sort((x, y) => (int) (x.Period - y.Period));
        //    var maxPeriod = RecipeList[RecipeList.Count - 1].Period;

        //    double totalCost = 0;
        //    double remaininSecond = saniye;
        //    double currentPeriodCost = 0;
        //    Recipe previousRecipe = null;

        //    int i = 0;
        //    int i2 = 0;

        //    do
        //    {
        //        currentPeriodCost = 0d;

        //        do
        //        {
        //            var recipe = RecipeList[i2];

        //            if (previousRecipe != null && previousRecipe.Period < remaininSecond && remaininSecond <= recipe.Period)
        //            {
        //                currentPeriodCost = recipe.Cost;
        //            }
        //            else if (remaininSecond >= recipe.Period)
        //            {
        //                currentPeriodCost = recipe.Cost;
        //            }
        //        } 
        //        while (i2++ < RecipeList.Count-1);

        //        totalCost += currentPeriodCost;
        //        remaininSecond -= maxPeriod;

        //    } 
        //    while (i++ < Math.Ceiling(saniye / maxPeriod) - 1);

        //    return totalCost;
        //}
    }
}

