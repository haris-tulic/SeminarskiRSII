using eAutobusModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAutobus.WinUI.Login
{
    public partial class frmLogin : Form
    {
        private readonly APIService _api = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            APIService.Username = txtUserName.Text;
            APIService.Password = txtPassword.Text;
            try
            {
                var result =await _api.Get<List<KorisnikModel>>(null);
                frmPocetna frm = new frmPocetna();
                frm.Show();
            }
            catch 
            {

                MessageBox.Show("Pogrešan username ili password!");
            }
        }
    }
}
