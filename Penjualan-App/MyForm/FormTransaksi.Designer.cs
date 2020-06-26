namespace Penjualan_App.MyForm
{
    partial class FormTransaksi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_kwitansi = new System.Windows.Forms.DateTimePicker();
            this.textBox_namapelanggan = new System.Windows.Forms.TextBox();
            this.textBox_idpelanggan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kwitansi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total_seluruh = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_transaksi = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.textBox_jumlah = new System.Windows.Forms.TextBox();
            this.textBox_harga = new System.Windows.Forms.TextBox();
            this.textBox_namabarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_kodebarang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.btn_cari_pelanggan = new System.Windows.Forms.Button();
            this.btn_cari_barang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cari_pelanggan);
            this.groupBox1.Controls.Add(this.dateTimePicker_kwitansi);
            this.groupBox1.Controls.Add(this.textBox_namapelanggan);
            this.groupBox1.Controls.Add(this.textBox_idpelanggan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_kwitansi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Transaksi Penjualan ::";
            // 
            // dateTimePicker_kwitansi
            // 
            this.dateTimePicker_kwitansi.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker_kwitansi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_kwitansi.Location = new System.Drawing.Point(305, 59);
            this.dateTimePicker_kwitansi.Name = "dateTimePicker_kwitansi";
            this.dateTimePicker_kwitansi.Size = new System.Drawing.Size(145, 25);
            this.dateTimePicker_kwitansi.TabIndex = 4;
            // 
            // textBox_namapelanggan
            // 
            this.textBox_namapelanggan.Location = new System.Drawing.Point(208, 169);
            this.textBox_namapelanggan.Name = "textBox_namapelanggan";
            this.textBox_namapelanggan.Size = new System.Drawing.Size(242, 25);
            this.textBox_namapelanggan.TabIndex = 2;
            // 
            // textBox_idpelanggan
            // 
            this.textBox_idpelanggan.Location = new System.Drawing.Point(6, 169);
            this.textBox_idpelanggan.Name = "textBox_idpelanggan";
            this.textBox_idpelanggan.Size = new System.Drawing.Size(131, 25);
            this.textBox_idpelanggan.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nama Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID Pelanggan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tgl Kwitansi";
            // 
            // textBox_kwitansi
            // 
            this.textBox_kwitansi.Location = new System.Drawing.Point(305, 25);
            this.textBox_kwitansi.Name = "textBox_kwitansi";
            this.textBox_kwitansi.Size = new System.Drawing.Size(145, 25);
            this.textBox_kwitansi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "No Kwitansi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Penjualan_App.Properties.Resources._3d_bar_chart;
            this.pictureBox1.Location = new System.Drawing.Point(34, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.total_seluruh);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dataGridView_transaksi);
            this.groupBox2.Location = new System.Drawing.Point(500, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 509);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = ":: Data Transaksi";
            // 
            // total_seluruh
            // 
            this.total_seluruh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.total_seluruh.AutoSize = true;
            this.total_seluruh.Location = new System.Drawing.Point(149, 469);
            this.total_seluruh.Name = "total_seluruh";
            this.total_seluruh.Size = new System.Drawing.Size(15, 17);
            this.total_seluruh.TabIndex = 4;
            this.total_seluruh.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Total Seluruh Rp.";
            // 
            // dataGridView_transaksi
            // 
            this.dataGridView_transaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_transaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transaksi.Location = new System.Drawing.Point(6, 24);
            this.dataGridView_transaksi.Name = "dataGridView_transaksi";
            this.dataGridView_transaksi.Size = new System.Drawing.Size(535, 428);
            this.dataGridView_transaksi.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cari_barang);
            this.groupBox3.Controls.Add(this.button_minus);
            this.groupBox3.Controls.Add(this.button_plus);
            this.groupBox3.Controls.Add(this.textBox_jumlah);
            this.groupBox3.Controls.Add(this.textBox_harga);
            this.groupBox3.Controls.Add(this.textBox_namabarang);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_kodebarang);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 199);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = ":: Ambil Barang ::";
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(421, 109);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(35, 25);
            this.button_minus.TabIndex = 4;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(384, 109);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(35, 25);
            this.button_plus.TabIndex = 4;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            // 
            // textBox_jumlah
            // 
            this.textBox_jumlah.Location = new System.Drawing.Point(208, 109);
            this.textBox_jumlah.Name = "textBox_jumlah";
            this.textBox_jumlah.Size = new System.Drawing.Size(166, 25);
            this.textBox_jumlah.TabIndex = 2;
            // 
            // textBox_harga
            // 
            this.textBox_harga.Location = new System.Drawing.Point(6, 109);
            this.textBox_harga.Name = "textBox_harga";
            this.textBox_harga.Size = new System.Drawing.Size(182, 25);
            this.textBox_harga.TabIndex = 2;
            // 
            // textBox_namabarang
            // 
            this.textBox_namabarang.Location = new System.Drawing.Point(208, 47);
            this.textBox_namabarang.Name = "textBox_namabarang";
            this.textBox_namabarang.Size = new System.Drawing.Size(242, 25);
            this.textBox_namabarang.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kode Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Jumlah";
            // 
            // textBox_kodebarang
            // 
            this.textBox_kodebarang.Location = new System.Drawing.Point(6, 47);
            this.textBox_kodebarang.Name = "textBox_kodebarang";
            this.textBox_kodebarang.Size = new System.Drawing.Size(131, 25);
            this.textBox_kodebarang.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nama Barang\r\n";
            // 
            // button_simpan
            // 
            this.button_simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_simpan.Image = global::Penjualan_App.Properties.Resources.Save;
            this.button_simpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_simpan.Location = new System.Drawing.Point(334, 481);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(147, 39);
            this.button_simpan.TabIndex = 1;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            // 
            // button_baru
            // 
            this.button_baru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_baru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_baru.Image = global::Penjualan_App.Properties.Resources.New_document;
            this.button_baru.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_baru.Location = new System.Drawing.Point(18, 481);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(147, 39);
            this.button_baru.TabIndex = 1;
            this.button_baru.Text = "Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            // 
            // btn_cari_pelanggan
            // 
            this.btn_cari_pelanggan.Image = global::Penjualan_App.Properties.Resources.Zoom;
            this.btn_cari_pelanggan.Location = new System.Drawing.Point(143, 169);
            this.btn_cari_pelanggan.Name = "btn_cari_pelanggan";
            this.btn_cari_pelanggan.Size = new System.Drawing.Size(55, 25);
            this.btn_cari_pelanggan.TabIndex = 5;
            this.btn_cari_pelanggan.UseVisualStyleBackColor = true;
            this.btn_cari_pelanggan.Click += new System.EventHandler(this.btn_cari_pelanggan_Click);
            // 
            // btn_cari_barang
            // 
            this.btn_cari_barang.Image = global::Penjualan_App.Properties.Resources.Zoom;
            this.btn_cari_barang.Location = new System.Drawing.Point(143, 46);
            this.btn_cari_barang.Name = "btn_cari_barang";
            this.btn_cari_barang.Size = new System.Drawing.Size(55, 25);
            this.btn_cari_barang.TabIndex = 5;
            this.btn_cari_barang.UseVisualStyleBackColor = true;
            this.btn_cari_barang.Click += new System.EventHandler(this.btn_cari_barang_Click);
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 533);
            this.Controls.Add(this.button_baru);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Form Transaksi ::";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transaksi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_transaksi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_namapelanggan;
        private System.Windows.Forms.TextBox textBox_idpelanggan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kwitansi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_jumlah;
        private System.Windows.Forms.TextBox textBox_harga;
        private System.Windows.Forms.TextBox textBox_namabarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_kodebarang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.DateTimePicker dateTimePicker_kwitansi;
        private System.Windows.Forms.Label total_seluruh;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button btn_cari_pelanggan;
        private System.Windows.Forms.Button btn_cari_barang;
    }
}