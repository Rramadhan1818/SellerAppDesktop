using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Penjualan_App.MyForm
{
    public partial class FormUtama : Form
    {
        // 1. buat form jadi objeck
        FormBarang brg;
        FormPelanggan plgn;
        FormTransaksi trx;

        // 2. buat prosedur closed_brg
        void brg_FormClosed(Object sender, FormClosedEventArgs e) {
            brg = null;
        }

        void plgn_FormClosed(Object sender, FormClosedEventArgs e)
        {
            plgn = null;
        }

        void trx_FormClosed(Object sender, FormClosedEventArgs e)
        {
            trx = null;
        }

        public FormUtama()
        {
            InitializeComponent();
        }

        private void submenu_barang_Click(object sender, EventArgs e)
        {
            if (brg == null)
            {
                brg = new FormBarang();
                brg.MdiParent = this;
                //panggil void form close 
                brg.FormClosed += new FormClosedEventHandler(brg_FormClosed);
                brg.Show();
            }
            else
            {
                brg.Activate();
            }
        }

        private void submenu_pelanggan_Click(object sender, EventArgs e)
        {
            if (plgn == null)
            {
                plgn = new FormPelanggan();
                plgn.MdiParent = this;
                //panggil void form close 
                plgn.FormClosed += new FormClosedEventHandler(plgn_FormClosed);
                plgn.Show();
            }
            else
            {
                plgn.Activate();
            }
        }

        private void submenu_penjualan_Click(object sender, EventArgs e)
        {
            if (trx == null)
            {
                trx = new FormTransaksi();
                trx.MdiParent = this;
                //panggil void form close 
                trx.FormClosed += new FormClosedEventHandler(trx_FormClosed);
                trx.Show();
            }
            else
            {
                trx.Activate();
            }
        }
    }
}
