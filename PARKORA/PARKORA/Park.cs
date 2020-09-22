using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            TrackSlot = new Slot(5, new List<Recipe> { new Recipe(5, 0), new Recipe(1500, 30) });
            BusSlot = new Slot(5, new List<Recipe> { new Recipe(2, 0), new Recipe(1500, 25) });
            CarSlot = new Slot(5, new List<Recipe> { new Recipe(2, 0), new Recipe(1500, 20) });
            MotorbikeSlot = new Slot(5, new List<Recipe> { new Recipe(3, 0), new Recipe(1500, 15) });
        }

        public void ParkIn(Vehicle vehicle, MaskedTextBox textBox) //Parka giriş için kullnılan metod.
        {

            try
            {
                vehicle.CheckPlate(textBox);
            }
            catch (Exception e)
            {
                MessageBox.Show("HATALI PLAKA");
                return;
            }

            switch (vehicle.Type)
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

            switch (vehicle.Type)
            {
                case VehicleType.Truck:
                    this.TrackSlot.SlotOut(vehicle.Plate);
                    break;
                case VehicleType.Bus:
                    this.BusSlot.SlotOut(vehicle.Plate);
                    break;
                case VehicleType.Car:
                    this.CarSlot.SlotOut(vehicle.Plate);
                    break;
                case VehicleType.Motorbike:
                    this.MotorbikeSlot.SlotOut(vehicle.Plate);
                    break;
            }
        }
        public List<Ticket> GetParkIn()
        {
            var ticketList = new List<Ticket>();
            ticketList.AddRange(TrackSlot.GetSlotIn());
            ticketList.AddRange(BusSlot.GetSlotIn());
            ticketList.AddRange(CarSlot.GetSlotIn());
            ticketList.AddRange(MotorbikeSlot.GetSlotIn());
            return ticketList;
        }

        public List<Ticket> GetParkOut()
        {
            var ticketList = new List<Ticket>();
            ticketList.AddRange(TrackSlot.GetSlotOut());
            ticketList.AddRange(BusSlot.GetSlotOut());
            ticketList.AddRange(CarSlot.GetSlotOut());
            ticketList.AddRange(MotorbikeSlot.GetSlotOut());
            return ticketList;
        }
    }
}
