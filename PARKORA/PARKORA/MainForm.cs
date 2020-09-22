using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARKORA
{
    public partial class MainForm : Form
    {
        private Park park;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillCombos();
            this.park = new Park();
        }

        void fillCombos()
        {
            cmbSinif.DataSource = Enum.GetValues(typeof(VehicleType));
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Vehicle arac = new Vehicle(txtPlaka.Text, (VehicleType)cmbSinif.SelectedItem);

            this.park.ParkIn(arac,txtPlaka);

            refreshList();

            txtPlaka.Text = "";

            txtPlaka.Focus();
        }

        private void txtPlaka_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm(park.GetParkOut());
            rf.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedTicket = (Ticket)lstAraclar.SelectedValue;

            DialogResult sonuc = MessageBox.Show(selectedTicket.Vehicle.Plate+ " plakalı aracın çıkışını onaylıyor musunuz?", "DİKKAT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sonuc == DialogResult.Yes)
            {
                park.ParkOut(selectedTicket.Vehicle);
                refreshList();
            }
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void cmbSinif_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void refreshList()
        {
            var mapped = park.GetParkIn().Select(ticket => new
            {
                Display = ticket.Vehicle.Plate + "   " + ticket.Vehicle.Type + "  " + ticket.TimeIn,
                Ticket = ticket
            }).ToList();
            lstAraclar.DataSource = mapped;
            lstAraclar.DisplayMember = "Display";
            lstAraclar.ValueMember = "Ticket";
        }

        private void txtPlaka_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txtPlaka.Text = txtPlaka.Text.ToUpper();
            txtPlaka.SelectionStart = txtPlaka.Text.Length;
        }
    }
}
