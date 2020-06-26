using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//using System.Data.SqlClient;

namespace Penjualan_App.MyForm
{
    public partial class FormBarang : Form
    {
        // Tambahkan variable untuk perintah sql
        private MySqlCommand cmd; //untuk membuat printahquery
        private DataSet ds; // menampilkan data
        private MySqlDataAdapter da; //mengeksekusi printah sql

        //Koneksi dari package (kelas/koneksi.cs) jadikan objek -> konn
        MyClass.Koneksi konn = new MyClass.Koneksi();
        //MySqlConnection kon = Koneksi.konek();

        // prosedur clear
        void clear()
        {
            textBox_kodebarang.Text = "";
            textBox_namabarang.Text = "";
            textBox_hargabarang.Text = "0";
            textBox_stokbarang.Text = "0";
            textBox_cari.Text = "";
            comboBox_satuanbarang.Text = "- Pilih Satuan -";
        }

        //prosedur atur button
        void atur_button(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }

        // prosedur refresh barang
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

        }

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

        void auto_number()
        {
            long hitung;
            string urutan;
            MySqlDataReader rd;
            MySqlConnection conn = konn.GetKoneksi();
            conn.Open();
            cmd = new MySqlCommand("SELECT KodeBarang from tbl_barang where KodeBarang in (select max(KodeBarang) from tbl_barang) order by KodeBarang desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["KodeBarang"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "B" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urutan = "B001";
            }
            rd.Close();
            textBox_kodebarang.Enabled = false;
            textBox_kodebarang.Text = urutan;
            conn.Close();
        }

        public FormBarang()
        {
            InitializeComponent();
            clear();
            atur_button(false);
            refresh_barang();
            //panggil auto number
            auto_number();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = @"Server=localhost;Port=3306;Uid=root;password=;database=db_penjualan;pooling=true";
                MySqlConnection conn = new MySqlConnection(strConn);
                conn.Open();
                MessageBox.Show("Koneksi siap");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_barang();
        }

        // Perintah simpan
        private void button_simpan_Click(object sender, EventArgs e)
        {
            //make validasi
            if (textBox_kodebarang.Text.Trim() == "" || textBox_namabarang.Text.Trim() == "" || textBox_stokbarang.Text.Trim() == "" || textBox_hargabarang.Text.Trim() == "" || comboBox_satuanbarang.Text.Trim() == "")
            {
                //pesan belum lengkap
                MessageBox.Show("Data Belum Lengkap, Lengkapi data terlebih dahulu! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Persiapkan sql connection
                MySqlConnection conn = konn.GetKoneksi();
                try
                {
                    cmd = new MySqlCommand("insert into tbl_barang values ('" + textBox_kodebarang.Text + "', '" + textBox_namabarang.Text + "', '" + textBox_hargabarang.Text + "', '" + textBox_stokbarang.Text + "', '" + comboBox_satuanbarang.Text + "')", conn);
                    //membuka koneksi
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //tampilkan pesan
                    MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
                    clear();
                    atur_button(false);
                    auto_number();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                } 
            }
        }

        private void dataGridView_barang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //mengambil nilai dari row tabel
            try
            {
                button_simpan.Enabled = false;
                atur_button(true);

                DataGridViewRow row = this.dataGridView_barang.Rows[e.RowIndex];
                textBox_kodebarang.Text = row.Cells["KodeBarang"].Value.ToString();
                textBox_namabarang.Text = row.Cells["NamaBarang"].Value.ToString();
                textBox_hargabarang.Text = row.Cells["Harga"].Value.ToString();
                textBox_stokbarang.Text = row.Cells["Stok"].Value.ToString();
                comboBox_satuanbarang.Text = row.Cells["Satuan"].Value.ToString();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            //make validasi
            if (textBox_kodebarang.Text.Trim() == "" || textBox_namabarang.Text.Trim() == "" || textBox_stokbarang.Text.Trim() == "" || textBox_hargabarang.Text.Trim() == "" || comboBox_satuanbarang.Text.Trim() == "")
            {
                //pesan belum lengkap
                MessageBox.Show("Data Belum Lengkap, Lengkapi data terlebih dahulu! ", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Persiapkan sql connection
                MySqlConnection conn = konn.GetKoneksi();
                try
                {
                    cmd = new MySqlCommand("update tbl_barang set NamaBarang = '"+textBox_namabarang.Text+ "', Harga = '" + textBox_hargabarang.Text + "', Stok = '" + textBox_stokbarang.Text + "', Satuan = '" + comboBox_satuanbarang.Text + "' where KodeBarang = '" + textBox_kodebarang.Text + "' ", conn);
                    //membuka koneksi
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //tampilkan pesan
                    MessageBox.Show("Data Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
                    clear();
                    atur_button(false);
                    auto_number();
                    button_simpan.Enabled = true;
                    
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            // membuat perintah hapus
            if (MessageBox.Show("Yakin data barang : " + textBox_namabarang.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Persiapkan sql connection
                MySqlConnection conn = konn.GetKoneksi();
                {
                    cmd = new MySqlCommand("delete from tbl_barang where KodeBarang = '"+textBox_kodebarang.Text+"' ", conn);
                    //membuka koneksi
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //tampilkan pesan
                    MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_barang();
                    clear();
                    atur_button(false);
                    auto_number();
                    button_simpan.Enabled = true;
                }
            }
        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            //panggilprosedur bersih dan atur button
            clear();
            atur_button(false);
            button_simpan.Enabled = true;
            auto_number();
        }

    
    }
}
