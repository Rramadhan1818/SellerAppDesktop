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


namespace Penjualan_App.MyForm
{
    public partial class FormPelanggan : Form
    {

        // Tambahkan variable untuk perintah sql
        private MySqlCommand cmd; //untuk membuat printahquery
        private DataSet ds; // menampilkan data
        private MySqlDataAdapter da; //mengeksekusi printah sql

        //Koneksi dari package (kelas/koneksi.cs) jadikan objek -> konn
        MyClass.Koneksi konn = new MyClass.Koneksi();
        //MySqlConnection kon = Koneksi.konek();


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

        }

        void clear()
        {
            textBox_idpelanggan.Text = "";     
            textBox_namapelanggan.Text = "";
            textBox_alamatpelanggan.Text = "";
            textBox_notelp.Text = "";
            textBox_namapelanggan.Focus();
        }

        void atur_button(Boolean status)
        {
            button_ubah.Enabled = status;
            button_hapus.Enabled = status;
        }

        public FormPelanggan()
        {
            InitializeComponent();
            clear();
            atur_button(false);
            refresh_pelanggan();
            auto_id();
        }

        private void FormPelanggan_Load(object sender, EventArgs e)
        {

        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            cari_pelanggan();
        }

        void auto_id()
        {
            long hitung;
            string urutan;
            MySqlDataReader rd;
            MySqlConnection conn = konn.GetKoneksi();
            conn.Open();
            cmd = new MySqlCommand("SELECT IdPelanggan from tbl_pelanggan where IdPelanggan in (select max(IdPelanggan) from tbl_pelanggan) order by IdPelanggan desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["IdPelanggan"].ToString().Length - 3, 3)) + 1;
                string joinstr = "000" + hitung;
                urutan = "P" + joinstr.Substring(joinstr.Length - 3, 3);
            }
            else
            {
                urutan = "P001";
            }
            rd.Close();
            textBox_idpelanggan.Enabled = false;
            textBox_idpelanggan.Text = urutan;
            conn.Close();
        }


        private void button_simpan_Click(object sender, EventArgs e)
        {
            //make validasi
            if (textBox_idpelanggan.Text.Trim() == "" || textBox_namapelanggan.Text.Trim() == "" || textBox_alamatpelanggan.Text.Trim() == "" || textBox_notelp.Text.Trim() == "")
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
                    cmd = new MySqlCommand("insert into tbl_pelanggan values ('" + textBox_idpelanggan.Text + "', '" + textBox_namapelanggan.Text + "', '" + textBox_alamatpelanggan.Text + "', '" + textBox_notelp.Text + "')", conn);
                    //membuka koneksi
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //tampilkan pesan
                    MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_pelanggan();
                    clear();
                    atur_button(false);
                    auto_id();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.ToString());
                }
            }
        }

        private void dataGridView_pelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //mengambil nilai dari row tabel
            try
            {
                button_simpan.Enabled = false;
                atur_button(true);

                DataGridViewRow row = this.dataGridView_pelanggan.Rows[e.RowIndex];
                textBox_idpelanggan.Text = row.Cells["IdPelanggan"].Value.ToString();
                textBox_namapelanggan.Text = row.Cells["NamaPelanggan"].Value.ToString();
                textBox_alamatpelanggan.Text = row.Cells["Alamat"].Value.ToString();
                textBox_notelp.Text = row.Cells["NoTelepon"].Value.ToString();

            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            //make validasi
            if (textBox_idpelanggan.Text.Trim() == "" || textBox_namapelanggan.Text.Trim() == "" || textBox_alamatpelanggan.Text.Trim() == "" || textBox_notelp.Text.Trim() == "")
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
                    cmd = new MySqlCommand("update tbl_pelanggan set NamaPelanggan = '"+textBox_namapelanggan.Text+ "', Alamat = '" + textBox_alamatpelanggan.Text + "', NoTelepon = '" + textBox_notelp.Text + "' where IdPelanggan = '" + textBox_idpelanggan.Text + "'", conn);
                    //membuka koneksi
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //tampilkan pesan
                    MessageBox.Show("Data Berhasil Diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_pelanggan();
                    clear();
                    atur_button(false);
                    auto_id();
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
            if (MessageBox.Show("Yakin data barang : " + textBox_namapelanggan.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Persiapkan sql connection
                MySqlConnection conn = konn.GetKoneksi();
                {
                    cmd = new MySqlCommand("delete from tbl_pelanggan where IdPelanggan = '" + textBox_idpelanggan.Text + "' ", conn);
                    //membuka koneksi
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    //tampilkan pesan
                    MessageBox.Show("Data Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_pelanggan();
                    clear();
                    atur_button(false);
                    auto_id();
                    button_simpan.Enabled = true;
                }
            }
        }

        private void cek_koneksi_Click(object sender, EventArgs e)
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

        private void button_baru_Click(object sender, EventArgs e)
        {
            //panggilprosedur bersih dan atur button
            clear();
            atur_button(false);
            button_simpan.Enabled = true;
            auto_id();
        }
    }
}
