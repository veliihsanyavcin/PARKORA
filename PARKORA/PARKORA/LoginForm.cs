using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARKORA
{
    public partial class LoginForm : Form
    {
        Account account = new Account();

        public LoginForm()
        {
            InitializeComponent();
        }
      
        private void btnGiris_Click(object sender, EventArgs e)
        {

            this.account.Login(txtKullaniciAdi, txtParola, errorProvider1, this);

        }
    }
}
