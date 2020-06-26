namespace Penjualan_App.MyForm
{
    partial class FormPelanggan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.dataGridView_pelanggan = new System.Windows.Forms.DataGridView();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_proses = new System.Windows.Forms.GroupBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.textBox_notelp = new System.Windows.Forms.TextBox();
            this.textBox_alamatpelanggan = new System.Windows.Forms.TextBox();
            this.textBox_namapelanggan = new System.Windows.Forms.TextBox();
            this.textBox_idpelanggan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cek_koneksi = new System.Windows.Forms.Button();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).BeginInit();
            this.groupBox_proses.SuspendLayout();
            this.groupBox_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_data
            // 
            this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_data.Controls.Add(this.dataGridView_pelanggan);
            this.groupBox_data.Controls.Add(this.textBox_cari);
            this.groupBox_data.Controls.Add(this.label7);
            this.groupBox_data.Location = new System.Drawing.Point(399, 17);
            this.groupBox_data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_data.Size = new System.Drawing.Size(546, 484);
            this.groupBox_data.TabIndex = 1;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = ":: Data Pelanggan ::";
            // 
            // dataGridView_pelanggan
            // 
            this.dataGridView_pelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pelanggan.Location = new System.Drawing.Point(16, 66);
            this.dataGridView_pelanggan.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_pelanggan.Name = "dataGridView_pelanggan";
            this.dataGridView_pelanggan.Size = new System.Drawing.Size(514, 403);
            this.dataGridView_pelanggan.TabIndex = 2;
            this.dataGridView_pelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pelanggan_CellClick);
            // 
            // textBox_cari
            // 
            this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cari.Location = new System.Drawing.Point(212, 29);
            this.textBox_cari.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(291, 25);
            this.textBox_cari.TabIndex = 1;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cari Barang (Kode / Nama)";
            // 
            // groupBox_proses
            // 
            this.groupBox_proses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_proses.Controls.Add(this.button_hapus);
            this.groupBox_proses.Controls.Add(this.button_ubah);
            this.groupBox_proses.Controls.Add(this.button_simpan);
            this.groupBox_proses.Controls.Add(this.button_baru);
            this.groupBox_proses.Location = new System.Drawing.Point(3, 347);
            this.groupBox_proses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_proses.Name = "groupBox_proses";
            this.groupBox_proses.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_proses.Size = new System.Drawing.Size(390, 154);
            this.groupBox_proses.TabIndex = 2;
            this.groupBox_proses.TabStop = false;
            this.groupBox_proses.Text = ":: Proses ::";
            // 
            // button_hapus
            // 
            this.button_hapus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.Image = global::Penjualan_App.Properties.Resources.Delete;
            this.button_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hapus.Location = new System.Drawing.Point(208, 93);
            this.button_hapus.Margin = new System.Windows.Forms.Padding(2);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(127, 33);
            this.button_hapus.TabIndex = 0;
            this.button_hapus.Text = "&Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // button_ubah
            // 
            this.button_ubah.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ubah.Image = global::Penjualan_App.Properties.Resources.Update;
            this.button_ubah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ubah.Location = new System.Drawing.Point(50, 93);
            this.button_ubah.Margin = new System.Windows.Forms.Padding(2);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(130, 33);
            this.button_ubah.TabIndex = 0;
            this.button_ubah.Text = "&Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            this.button_ubah.Click += new System.EventHandler(this.button_ubah_Click);
            // 
            // button_simpan
            // 
            this.button_simpan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Image = global::Penjualan_App.Properties.Resources.Save;
            this.button_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_simpan.Location = new System.Drawing.Point(208, 44);
            this.button_simpan.Margin = new System.Windows.Forms.Padding(2);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(127, 33);
            this.button_simpan.TabIndex = 0;
            this.button_simpan.Text = "&Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_baru
            // 
            this.button_baru.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_baru.Image = global::Penjualan_App.Properties.Resources.New_document;
            this.button_baru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_baru.Location = new System.Drawing.Point(50, 44);
            this.button_baru.Margin = new System.Windows.Forms.Padding(2);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(130, 33);
            this.button_baru.TabIndex = 0;
            this.button_baru.Text = "&Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.cek_koneksi);
            this.groupBox_form.Controls.Add(this.textBox_notelp);
            this.groupBox_form.Controls.Add(this.textBox_alamatpelanggan);
            this.groupBox_form.Controls.Add(this.textBox_namapelanggan);
            this.groupBox_form.Controls.Add(this.textBox_idpelanggan);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Location = new System.Drawing.Point(3, 17);
            this.groupBox_form.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_form.Size = new System.Drawing.Size(390, 322);
            this.groupBox_form.TabIndex = 3;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = ":: Form Pelanggan ::";
            // 
            // textBox_notelp
            // 
            this.textBox_notelp.Location = new System.Drawing.Point(147, 231);
            this.textBox_notelp.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_notelp.Name = "textBox_notelp";
            this.textBox_notelp.Size = new System.Drawing.Size(172, 25);
            this.textBox_notelp.TabIndex = 1;
            // 
            // textBox_alamatpelanggan
            // 
            this.textBox_alamatpelanggan.Location = new System.Drawing.Point(147, 111);
            this.textBox_alamatpelanggan.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_alamatpelanggan.Multiline = true;
            this.textBox_alamatpelanggan.Name = "textBox_alamatpelanggan";
            this.textBox_alamatpelanggan.Size = new System.Drawing.Size(222, 105);
            this.textBox_alamatpelanggan.TabIndex = 1;
            // 
            // textBox_namapelanggan
            // 
            this.textBox_namapelanggan.Location = new System.Drawing.Point(147, 73);
            this.textBox_namapelanggan.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_namapelanggan.Name = "textBox_namapelanggan";
            this.textBox_namapelanggan.Size = new System.Drawing.Size(222, 25);
            this.textBox_namapelanggan.TabIndex = 1;
            // 
            // textBox_idpelanggan
            // 
            this.textBox_idpelanggan.Location = new System.Drawing.Point(147, 37);
            this.textBox_idpelanggan.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_idpelanggan.Name = "textBox_idpelanggan";
            this.textBox_idpelanggan.Size = new System.Drawing.Size(79, 25);
            this.textBox_idpelanggan.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 231);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "No Telepon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alamat\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pelanggan";
            // 
            // cek_koneksi
            // 
            this.cek_koneksi.Location = new System.Drawing.Point(27, 282);
            this.cek_koneksi.Name = "cek_koneksi";
            this.cek_koneksi.Size = new System.Drawing.Size(105, 23);
            this.cek_koneksi.TabIndex = 2;
            this.cek_koneksi.Text = "Cek Koneksi";
            this.cek_koneksi.UseVisualStyleBackColor = true;
            this.cek_koneksi.Click += new System.EventHandler(this.cek_koneksi_Click);
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 518);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_proses);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Form Pelanggan ::";
            this.Load += new System.EventHandler(this.FormPelanggan_Load);
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pelanggan)).EndInit();
            this.groupBox_proses.ResumeLayout(false);
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.DataGridView dataGridView_pelanggan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_proses;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.TextBox textBox_notelp;
        private System.Windows.Forms.TextBox textBox_alamatpelanggan;
        private System.Windows.Forms.TextBox textBox_namapelanggan;
        private System.Windows.Forms.TextBox textBox_idpelanggan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Button cek_koneksi;
    }
}