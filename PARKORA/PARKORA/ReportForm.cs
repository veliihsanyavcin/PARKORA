using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PARKORA
{
    public partial class ReportForm : Form
    {
        List<Ticket> AracListesi;
        public ReportForm(List<Ticket> aracListesi)
        {
            InitializeComponent();
            this.AracListesi = aracListesi;
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {

            foreach (Ticket ticket in AracListesi)
            {
                ListViewItem satir1 = new ListViewItem(); //listviewıtem nesnesi listview'ın satırlarıdır. her araç için bir satır oluşturduk. //plaka, marka, sinif, abone, sure, ucret

                //satırın kolonlarını dolduruyoruz.

                satir1.SubItems.Add(ticket.Vehicle.Type.ToString());
                satir1.SubItems.Add(ticket.Vehicle.Plate);
                satir1.SubItems.Add(ticket.TimeIn.ToLongTimeString());
                satir1.SubItems.Add(ticket.TimeOut.ToLongTimeString());
                satir1.SubItems.Add((ticket.TimeOut - ticket.TimeIn).Seconds + " Saniye ");
                satir1.SubItems.Add(ticket.Cost.ToString("c2"));

                //satır nesnesi dolduruldu, şimdi listview'e ekliyoruz.
                reportList1.Items.Add(satir1);
            }

            foreach (VehicleType type in (VehicleType[])Enum.GetValues(typeof(VehicleType)))
            {
                ListViewItem satir2 = new ListViewItem();
                List<Ticket> TypeTickets = AracListesi.FindAll(t => t.Vehicle.Type == type);
                satir2.SubItems.Add(type.ToString());
                satir2.SubItems.Add(TypeTickets.Count.ToString());
                satir2.SubItems.Add(TypeTickets.Aggregate(0, (acc, x) => acc + (x.TimeOut - x.TimeIn).Seconds) + " Saniye ");
                satir2.SubItems.Add(TypeTickets.Aggregate(0.0, (acc, x) => acc + x.Cost).ToString("c2"));

                ozetList.Items.Add(satir2);
            }

            ListViewItem satir3 = new ListViewItem();
            satir3.SubItems.Add("TOPLAM");
            satir3.SubItems.Add(AracListesi.Count.ToString());
            satir3.SubItems.Add(AracListesi.Aggregate(0, (acc, x) => acc + (x.TimeOut - x.TimeIn).Seconds) + " Saniye ");
            satir3.SubItems.Add(AracListesi.Aggregate(0.0, (acc, x) => acc + x.Cost).ToString("c2"));

            ozetList.Items.Add(satir3);
        }
    }
}
