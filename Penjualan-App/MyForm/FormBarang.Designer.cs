namespace Penjualan_App.MyForm
{
    partial class FormBarang
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
            this.groupBox_form = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_satuanbarang = new System.Windows.Forms.ComboBox();
            this.textBox_stokbarang = new System.Windows.Forms.TextBox();
            this.textBox_hargabarang = new System.Windows.Forms.TextBox();
            this.textBox_namabarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_kodebarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_proses = new System.Windows.Forms.GroupBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.dataGridView_barang = new System.Windows.Forms.DataGridView();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_form.SuspendLayout();
            this.groupBox_proses.SuspendLayout();
            this.groupBox_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_form
            // 
            this.groupBox_form.Controls.Add(this.button1);
            this.groupBox_form.Controls.Add(this.comboBox_satuanbarang);
            this.groupBox_form.Controls.Add(this.textBox_stokbarang);
            this.groupBox_form.Controls.Add(this.textBox_hargabarang);
            this.groupBox_form.Controls.Add(this.textBox_namabarang);
            this.groupBox_form.Controls.Add(this.label5);
            this.groupBox_form.Controls.Add(this.textBox_kodebarang);
            this.groupBox_form.Controls.Add(this.label4);
            this.groupBox_form.Controls.Add(this.label3);
            this.groupBox_form.Controls.Add(this.label2);
            this.groupBox_form.Controls.Add(this.label1);
            this.groupBox_form.Location = new System.Drawing.Point(14, 16);
            this.groupBox_form.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_form.Name = "groupBox_form";
            this.groupBox_form.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_form.Size = new System.Drawing.Size(332, 274);
            this.groupBox_form.TabIndex = 0;
            this.groupBox_form.TabStop = false;
            this.groupBox_form.Text = ":: Form Barang ::";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cek Koneksi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_satuanbarang
            // 
            this.comboBox_satuanbarang.FormattingEnabled = true;
            this.comboBox_satuanbarang.Items.AddRange(new object[] {
            "Unit",
            "Kodi",
            "Lusin",
            "Pack",
            "Box"});
            this.comboBox_satuanbarang.Location = new System.Drawing.Point(124, 184);
            this.comboBox_satuanbarang.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_satuanbarang.Name = "comboBox_satuanbarang";
            this.comboBox_satuanbarang.Size = new System.Drawing.Size(188, 25);
            this.comboBox_satuanbarang.TabIndex = 2;
            // 
            // textBox_stokbarang
            // 
            this.textBox_stokbarang.Location = new System.Drawing.Point(124, 146);
            this.textBox_stokbarang.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_stokbarang.Name = "textBox_stokbarang";
            this.textBox_stokbarang.Size = new System.Drawing.Size(95, 25);
            this.textBox_stokbarang.TabIndex = 1;
            // 
            // textBox_hargabarang
            // 
            this.textBox_hargabarang.Location = new System.Drawing.Point(124, 109);
            this.textBox_hargabarang.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_hargabarang.Name = "textBox_hargabarang";
            this.textBox_hargabarang.Size = new System.Drawing.Size(142, 25);
            this.textBox_hargabarang.TabIndex = 1;
            // 
            // textBox_namabarang
            // 
            this.textBox_namabarang.Location = new System.Drawing.Point(124, 74);
            this.textBox_namabarang.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_namabarang.Name = "textBox_namabarang";
            this.textBox_namabarang.Size = new System.Drawing.Size(188, 25);
            this.textBox_namabarang.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Satuan";
            // 
            // textBox_kodebarang
            // 
            this.textBox_kodebarang.Location = new System.Drawing.Point(124, 37);
            this.textBox_kodebarang.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_kodebarang.Name = "textBox_kodebarang";
            this.textBox_kodebarang.Size = new System.Drawing.Size(79, 25);
            this.textBox_kodebarang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Harga Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Barang";
            // 
            // groupBox_proses
            // 
            this.groupBox_proses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_proses.Controls.Add(this.button_hapus);
            this.groupBox_proses.Controls.Add(this.button_ubah);
            this.groupBox_proses.Controls.Add(this.button_simpan);
            this.groupBox_proses.Controls.Add(this.button_baru);
            this.groupBox_proses.Location = new System.Drawing.Point(14, 347);
            this.groupBox_proses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_proses.Name = "groupBox_proses";
            this.groupBox_proses.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_proses.Size = new System.Drawing.Size(332, 154);
            this.groupBox_proses.TabIndex = 0;
            this.groupBox_proses.TabStop = false;
            this.groupBox_proses.Text = ":: Proses ::";
            // 
            // button_hapus
            // 
            this.button_hapus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.Image = global::Penjualan_App.Properties.Resources.Delete;
            this.button_hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hapus.Location = new System.Drawing.Point(185, 91);
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
            this.button_ubah.Location = new System.Drawing.Point(27, 91);
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
            this.button_simpan.Location = new System.Drawing.Point(185, 42);
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
            this.button_baru.Location = new System.Drawing.Point(27, 42);
            this.button_baru.Margin = new System.Windows.Forms.Padding(2);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(130, 33);
            this.button_baru.TabIndex = 0;
            this.button_baru.Text = "&Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            this.button_baru.Click += new System.EventHandler(this.button_baru_Click);
            // 
            // groupBox_data
            // 
            this.groupBox_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_data.Controls.Add(this.dataGridView_barang);
            this.groupBox_data.Controls.Add(this.textBox_cari);
            this.groupBox_data.Controls.Add(this.label7);
            this.groupBox_data.Location = new System.Drawing.Point(366, 16);
            this.groupBox_data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_data.Size = new System.Drawing.Size(482, 485);
            this.groupBox_data.TabIndex = 0;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = ":: Data Barang ::";
            // 
            // dataGridView_barang
            // 
            this.dataGridView_barang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_barang.Location = new System.Drawing.Point(16, 66);
            this.dataGridView_barang.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_barang.Name = "dataGridView_barang";
            this.dataGridView_barang.Size = new System.Drawing.Size(450, 404);
            this.dataGridView_barang.TabIndex = 2;
            this.dataGridView_barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_barang_CellClick);
            // 
            // textBox_cari
            // 
            this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cari.Location = new System.Drawing.Point(212, 29);
            this.textBox_cari.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(227, 25);
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
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(858, 513);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.groupBox_proses);
            this.Controls.Add(this.groupBox_form);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Data Barang ::";
            this.groupBox_form.ResumeLayout(false);
            this.groupBox_form.PerformLayout();
            this.groupBox_proses.ResumeLayout(false);
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_barang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_form;
        private System.Windows.Forms.TextBox textBox_kodebarang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_proses;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.TextBox textBox_stokbarang;
        private System.Windows.Forms.TextBox textBox_hargabarang;
        private System.Windows.Forms.TextBox textBox_namabarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_satuanbarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.DataGridView dataGridView_barang;
        private System.Windows.Forms.Button button1;
    }
}