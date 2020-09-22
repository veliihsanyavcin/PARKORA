using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PARKORA
{
    public partial class ReportForm : Form
    {
        public ReportForm(List<Ticket> List)
        {
            InitializeComponent();
            ozetList.Items[0].SubItems[2].Text = "0";
            ozetList.Items[0].SubItems[3].Text = "0";
            ozetList.Items[0].SubItems[4].Text = "0";
            ozetList.Items[1].SubItems[2].Text = "0";
            ozetList.Items[1].SubItems[3].Text = "0";
            ozetList.Items[1].SubItems[4].Text = "0";
            ozetList.Items[2].SubItems[2].Text = "0";
            ozetList.Items[2].SubItems[3].Text = "0";
            ozetList.Items[2].SubItems[4].Text = "0";
            ozetList.Items[3].SubItems[2].Text = "0";
            ozetList.Items[3].SubItems[3].Text = "0";
            ozetList.Items[3].SubItems[4].Text = "0";

            this.aracListesi = (List<Ticket>)List;

        }

        List<Ticket> aracListesi;
        private void RaporForm_Load(object sender, EventArgs e)
        {

            foreach (Ticket ticket in aracListesi)
            {
                ListViewItem satir = new ListViewItem();//listviewıtem nesnesi listview'ın satırlarıdır. her araç için bir satır oluşturduk. //plaka, marka, sinif, abone, sure, ucret

                //satırın kolonlarını dolduruyoruz.

                satir.SubItems.Add(ticket.Vehicle.Type.ToString());
                satir.SubItems.Add(ticket.Vehicle.Plate);
                satir.SubItems.Add(ticket.TimeIn.ToLongTimeString());
                satir.SubItems.Add(ticket.TimeOut.ToLongTimeString());
                satir.SubItems.Add((ticket.TimeOut - ticket.TimeIn).TotalSeconds + " Saniye ");
                satir.SubItems.Add(ticket.Cost.ToString("c2"));

                //satır nesnesi dolduruldu, şimdi listview'e ekliyoruz.
                reportList1.Items.Add(satir);


                if (ticket.Vehicle.Type.ToString() == "Truck")
                {
                    ozetList.Items[0].SubItems[2].Text = (Convert.ToInt32(ozetList.Items[0].SubItems[2].Text) + 1).ToString();
                    ozetList.Items[0].SubItems[3].Text = (Convert.ToDouble(ozetList.Items[0].SubItems[3].Text) + (Convert.ToDouble((ticket.TimeOut - ticket.TimeIn).TotalSeconds))).ToString();
                    ozetList.Items[0].SubItems[4].Text = (Convert.ToDouble(ozetList.Items[0].SubItems[4].Text) + ticket.Cost).ToString();
                }

                if (ticket.Vehicle.Type.ToString() == "Bus")
                {
                    ozetList.Items[1].SubItems[2].Text = (Convert.ToInt32(ozetList.Items[1].SubItems[2].Text) + 1).ToString();
                    ozetList.Items[1].SubItems[3].Text = (Convert.ToDouble(ozetList.Items[1].SubItems[3].Text) + (Convert.ToDouble((ticket.TimeOut - ticket.TimeIn).TotalSeconds))).ToString();
                    ozetList.Items[1].SubItems[4].Text = (Convert.ToDouble(ozetList.Items[1].SubItems[4].Text) + ticket.Cost).ToString();
                }

                if (ticket.Vehicle.Type.ToString() == "Car")
                {
                    ozetList.Items[2].SubItems[2].Text = (Convert.ToInt32(ozetList.Items[2].SubItems[2].Text) + 1).ToString();
                    ozetList.Items[2].SubItems[3].Text = (Convert.ToDouble(ozetList.Items[2].SubItems[3].Text) + (Convert.ToDouble((ticket.TimeOut - ticket.TimeIn).TotalSeconds))).ToString();
                    ozetList.Items[2].SubItems[4].Text = (Convert.ToDouble(ozetList.Items[2].SubItems[4].Text) + ticket.Cost).ToString();
                }

                if (ticket.Vehicle.Type.ToString() == "Motorbike")
                {
                    ozetList.Items[3].SubItems[2].Text = (Convert.ToInt32(ozetList.Items[3].SubItems[2].Text) + 1).ToString();
                    ozetList.Items[3].SubItems[3].Text = (Convert.ToDouble(ozetList.Items[3].SubItems[3].Text) + (Convert.ToDouble((ticket.TimeOut - ticket.TimeIn).TotalSeconds))).ToString();
                    ozetList.Items[3].SubItems[4].Text = (Convert.ToDouble(ozetList.Items[3].SubItems[4].Text) + ticket.Cost).ToString();
                }

                ozetList.Items[4].SubItems[4].Text = ((Convert.ToDouble(ozetList.Items[0].SubItems[4].Text)) +
                                                      (Convert.ToDouble(ozetList.Items[1].SubItems[4].Text)) +
                                                      (Convert.ToDouble(ozetList.Items[2].SubItems[4].Text)) +
                                                      (Convert.ToDouble(ozetList.Items[3].SubItems[4].Text))).ToString();

                ozetList.Items[4].SubItems[2].Text = ((Convert.ToDouble(ozetList.Items[0].SubItems[2].Text)) +
                                                      (Convert.ToDouble(ozetList.Items[1].SubItems[2].Text)) +
                                                      (Convert.ToDouble(ozetList.Items[2].SubItems[2].Text)) +
                                                      (Convert.ToDouble(ozetList.Items[3].SubItems[2].Text))).ToString();

                ozetList.Items[4].SubItems[3].Text = ((Convert.ToDouble(ozetList.Items[0].SubItems[3].Text)) +
                                                      (Convert.ToDouble(ozetList.Items[1].SubItems[3].Text)) +
                                                      (Convert.ToDouble(ozetList.Items[2].SubItems[3].Text)) + 
                                                      (Convert.ToDouble(ozetList.Items[3].SubItems[3].Text))).ToString();

            }

        }
    }
}
