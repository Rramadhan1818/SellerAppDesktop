using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //librarie xampp

namespace Penjualan_App.MyForm
{
    public partial class FormDialogBarang : Form
    {
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;

        public String kodebarang, namabarang, harga = "";

        MyClass.Koneksi konn = new MyClass.Koneksi(); 

        public FormDialogBarang()
        {
            InitializeComponent();
            refresh_barang();
        }

        void refresh_barang()
        {
            MySqlConnection conn = konn.GetKoneksi();
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("SELECT * from tbl_barang", conn);
                    ds = new DataSet();
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_barang");
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tbl_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();
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

        } // tutup refreshbarang

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_barang();
        }

        private void dataGridView_barang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
                kodebarang = row.Cells["KodeBarang"].Value.ToString();
                namabarang = row.Cells["NamaBarang"].Value.ToString();
                harga = row.Cells["Harga"].Value.ToString();
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }


        //fungsi untuk mengambil data barang unutk dialogbarang
        public String ambil_kode_barang
        {
            get
            {
                return kodebarang;
            }
        }

        public String ambil_nama_barang
        {
            get
            {
                return namabarang;
            }
        }

        public String ambil_harga
        {
            get
            {
                return harga;
            }
        }
        //tutup fungsi


        // prosedur cari barang
        void cari_barang()
        {
            MySqlConnection conn = konn.GetKoneksi();
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("SELECT * from tbl_barang where KodeBarang like '%" + textBox_cari.Text + "%' OR NamaBarang like '%" + textBox_cari.Text + "%' ", conn);
                    ds = new DataSet();
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(ds, "tbl_barang");
                    dataGridView_barang.DataSource = ds;
                    dataGridView_barang.DataMember = "tbl_barang";
                    dataGridView_barang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView_barang.AllowUserToAddRows = false;
                    dataGridView_barang.Refresh();
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

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
