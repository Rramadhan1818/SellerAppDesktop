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
    public partial class FormTransaksi : Form
    {
        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void btn_cari_pelanggan_Click(object sender, EventArgs e)
        {
            FormDialogPelanggan plg = new FormDialogPelanggan();
            plg.ShowDialog();
            textBox_idpelanggan.Text = plg.ambil_id_pelanggan;
            textBox_namapelanggan.Text = plg.ambil_nama_pelanggan;
        }

        private void btn_cari_barang_Click(object sender, EventArgs e)
        {
            FormDialogBarang brg = new FormDialogBarang();
            brg.ShowDialog();
            textBox_kodebarang.Text = brg.ambil_kode_barang;
            textBox_namabarang.Text = brg.ambil_nama_barang;
            textBox_harga.Text = brg.ambil_harga;

        }
    }
}
