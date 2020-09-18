using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARKORA
{
    public class Park
    {
        private Slot TrackSlot;
        private Slot BusSlot;
        private Slot CarSlot;
        private Slot MotorbikeSlot;

        public Park()
        {
            TrackSlot = new Slot(10, new List<Recipe> { new Recipe(15, 0), new Recipe(1500, 30) });
            BusSlot = new Slot(15, new List<Recipe> { new Recipe(20, 0), new Recipe(1500, 25) });
            CarSlot = new Slot(20, new List<Recipe> { new Recipe(25, 0), new Recipe(1500, 20) });
            MotorbikeSlot = new Slot(25, new List<Recipe> { new Recipe(30, 0), new Recipe(1500, 15) });
        }

        public void ParkIn(Vehicle vehicle) //Parka giriş için kullnılan metod.
        {
            try
            {
                vehicle.CheckPlate();
            }
            catch (Exception e)
            {
                Console.WriteLine("hata");
                throw;
            }

            switch (vehicle.GetType())
            {
                case VehicleType.Truck:
                    this.TrackSlot.SlotIn(vehicle);
                    break;
                case VehicleType.Bus:
                    this.BusSlot.SlotIn(vehicle);
                    break;
                case VehicleType.Car:
                    this.CarSlot.SlotIn(vehicle);
                    break;
                case VehicleType.Motorbike:
                    this.MotorbikeSlot.SlotIn(vehicle);
                    break;
            }

        }

        public void ParkOut(Vehicle vehicle)//Parktan çıkış için kullnılan metod.
        {

            switch (vehicle.GetType())
            {
                case VehicleType.Truck:
                    this.TrackSlot.SlotOut(vehicle.GetPlate());
                    break;
                case VehicleType.Bus:
                    this.BusSlot.SlotOut(vehicle.GetPlate());
                    break;
                case VehicleType.Car:
                    this.CarSlot.SlotOut(vehicle.GetPlate());
                    break;
                case VehicleType.Motorbike:
                    this.MotorbikeSlot.SlotOut(vehicle.GetPlate());
                    break;
            }
        }

        public List<List<Ticket>> Report() //Raporlama kısmı için kullandığımız metod
        {

            return new List<List<Ticket>> { TrackSlot.GetSlotOut(), BusSlot.GetSlotOut(), CarSlot.GetSlotOut(), MotorbikeSlot.GetSlotOut() };
        }
    }
}
