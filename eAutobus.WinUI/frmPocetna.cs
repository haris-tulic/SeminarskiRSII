using eAutobus.WinUI.Autobusi;
using eAutobus.WinUI.Karte;
using eAutobus.WinUI.Korisnici;
using eAutobus.WinUI.Recenzija;
using eAutobus.WinUI.RedVoznji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAutobus.WinUI
{
    public partial class frmPocetna : Form
    {
        private int childFormNumber = 0;

        public frmPocetna()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutobusiPrikaz frm = new frmAutobusiPrikaz();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void novoVoziloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajAutobus frm = new frmDodajAutobus();
            frm.Show();
        }

        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisniciPrikaz frm =  new frmKorisniciPrikaz();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void rasporedVoznjiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pregledRasporedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPregledRedaVoznji frm = new frmPregledRedaVoznji();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void dodajNovuLinijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodavanjeRedaVoznje frm = new frmDodavanjeRedaVoznje();
            frm.Show();
        }

        private void noviKorsnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisniciDodaj frm = new frmKorisniciDodaj();
            frm.Show();
        }

        private void pregledKarataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cjenovnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazKarata frm = new frmPrikazKarata();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void dodajNovuKartuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajKartu frm = new frmDodajKartu();
            frm.Show();
        }

        private void izdajKartuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIzdajKartu frm = new frmIzdajKartu();
            frm.Show();
           
        }

        private void recenzijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecenzija frm = new frmRecenzija();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void zahtjeviZaKartuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void onlineKarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOnlineKarte frm = new frmOnlineKarte();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void preuzećemKarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreuzecemKarte frm = new frmPreuzecemKarte();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
