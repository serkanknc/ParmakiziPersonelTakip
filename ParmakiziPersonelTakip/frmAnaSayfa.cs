using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParmakiziPersonelTakip
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void personelForm_Click(object sender, EventArgs e)
        {
            frmPersonelislemler frm = new frmPersonelislemler();
            frm.ShowDialog();
        }

        private void mesaiForm_Click(object sender, EventArgs e)
        {
            frmMesaiislemler frm = new frmMesaiislemler();
            frm.ShowDialog();
        }

        private void izinForm_Click(object sender, EventArgs e)
        {
            frmIzinislemler frm = new frmIzinislemler();
            frm.ShowDialog();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("ÇIKMAK İSTEDİĞİNİZE EMİN MİSİNİZ?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
