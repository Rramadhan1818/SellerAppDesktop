using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // tambah library sql MysqlClinet Untuk Xampp / SqlClient untuk sql server 

namespace Penjualan_App.MyForm
{
    public partial class FormDialogPelanggan : Form
    {

        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;

        public string idpelanggan, namapelanggan = "";

        MyClass.Koneksi konn = new MyClass.Koneksi();

        public FormDialogPelanggan()
        {
            InitializeComponent();
            refresh_pelanggan();
        }

        // prosedur refresh pelanggan
        void refresh_pelanggan()
        {
            MySqlConnection conn = konn.GetKoneksi();
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("SELECT * from tbl_pelanggan", conn);
                    ds = new DataSet();
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pelanggan");
                    dataGridView_pelanggan.DataSource = ds;
                    dataGridView_pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_pelanggan.AllowUserToAddRows = false;
                    dataGridView_pelanggan.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }

        } // tutup refresh pelanggan

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_pelanggan();
        }

        private void dataGridView_pelanggan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //mengisi variable dari datadgrid
                DataGridViewRow row = this.dataGridView_pelanggan.Rows[e.RowIndex];
                // variable yang tadinya kosong akan terisi
                idpelanggan = row.Cells["idPelanggan"].Value.ToString();
                namapelanggan = row.Cells["namaPelanggan"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public String ambil_id_pelanggan
        {
            get
            {
                return idpelanggan;
            }
        }

        public String ambil_nama_pelanggan
        {
            get
            {
                return namapelanggan;
            }
        }

        // prosedur cari barang
        void cari_pelanggan()
        {
            MySqlConnection conn = konn.GetKoneksi();
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("SELECT * from tbl_pelanggan where IdPelanggan like '%" + textBox_cari.Text + "%' OR NamaPelanggan like '%" + textBox_cari.Text + "%' ", conn);
                    ds = new DataSet();
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_pelanggan");
                    dataGridView_pelanggan.DataSource = ds;
                    dataGridView_pelanggan.DataMember = "tbl_pelanggan";
                    dataGridView_pelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_pelanggan.AllowUserToAddRows = false;
                    dataGridView_pelanggan.Refresh();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }

        } // tutup car pelanggan

    }
}
