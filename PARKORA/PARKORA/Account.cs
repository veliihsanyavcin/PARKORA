using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PARKORA
{
    public class Account
    {
        private const string UserName = "1"; //Giriş için kullanılan Kullanıcı adı.
        private const string Password = "1"; //.Giriş için kullanılan şifre.

        public void Login(TextBox UserName, TextBox Password, ErrorProvider ep, Form loginForm)
        {
            ep.Clear();

            if (UserName.Text.ToLower().Trim() == Account.UserName &&
                Password.Text.Trim() == Account.Password)

            {
                MainForm mainForm = new MainForm();

                UserName.Text = Password.Text = "";

                mainForm.Show();
                loginForm.Hide();
            }
            else
            {

                if (UserName.Text.ToLower().Trim() != Account.UserName)
                    ep.SetError(UserName, "Kullanıcı Adı Hatalı.");
                if (Password.Text.Trim() != Account.Password)
                    ep.SetError(Password, "Parola Hatalı");

            }
        }
    }
}
