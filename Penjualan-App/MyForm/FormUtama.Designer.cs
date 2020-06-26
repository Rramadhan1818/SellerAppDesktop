namespace Penjualan_App.MyForm
{
    partial class FormUtama
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_login = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.submenu_keluar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_barang = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_barang = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_pelanggan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_transaksi = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_penjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_laporan = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_laporanbrg = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_laporanplgn = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_pengaturan = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_ubahpw = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_tambahpengguna = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tentang = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_info = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolbar_barang = new System.Windows.Forms.ToolStripButton();
            this.toolbar_pelanggan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbar_transaksi = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_barang,
            this.menu_transaksi,
            this.menu_laporan,
            this.menu_pengaturan,
            this.menu_tentang});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_login,
            this.submenu_logout,
            this.toolStripMenuItem1,
            this.submenu_keluar});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(37, 20);
            this.menu_file.Text = "&File";
            // 
            // submenu_login
            // 
            this.submenu_login.Name = "submenu_login";
            this.submenu_login.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.submenu_login.Size = new System.Drawing.Size(193, 22);
            this.submenu_login.Text = "&Login";
            // 
            // submenu_logout
            // 
            this.submenu_logout.Name = "submenu_logout";
            this.submenu_logout.Size = new System.Drawing.Size(193, 22);
            this.submenu_logout.Text = "&Logout";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // submenu_keluar
            // 
            this.submenu_keluar.Name = "submenu_keluar";
            this.submenu_keluar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.submenu_keluar.Size = new System.Drawing.Size(193, 22);
            this.submenu_keluar.Text = "Keluar Aplikasi";
            // 
            // menu_barang
            // 
            this.menu_barang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_barang,
            this.submenu_pelanggan});
            this.menu_barang.Name = "menu_barang";
            this.menu_barang.Size = new System.Drawing.Size(82, 20);
            this.menu_barang.Text = "&Master Data";
            // 
            // submenu_barang
            // 
            this.submenu_barang.Name = "submenu_barang";
            this.submenu_barang.Size = new System.Drawing.Size(152, 22);
            this.submenu_barang.Text = "&Barang";
            this.submenu_barang.Click += new System.EventHandler(this.submenu_barang_Click);
            // 
            // submenu_pelanggan
            // 
            this.submenu_pelanggan.Name = "submenu_pelanggan";
            this.submenu_pelanggan.Size = new System.Drawing.Size(152, 22);
            this.submenu_pelanggan.Text = "&Pelanggan";
            this.submenu_pelanggan.Click += new System.EventHandler(this.submenu_pelanggan_Click);
            // 
            // menu_transaksi
            // 
            this.menu_transaksi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_penjualan});
            this.menu_transaksi.Name = "menu_transaksi";
            this.menu_transaksi.Size = new System.Drawing.Size(66, 20);
            this.menu_transaksi.Text = "&Transaksi";
            // 
            // submenu_penjualan
            // 
            this.submenu_penjualan.Name = "submenu_penjualan";
            this.submenu_penjualan.Size = new System.Drawing.Size(152, 22);
            this.submenu_penjualan.Text = "&Penjualan";
            this.submenu_penjualan.Click += new System.EventHandler(this.submenu_penjualan_Click);
            // 
            // menu_laporan
            // 
            this.menu_laporan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_laporanbrg,
            this.submenu_laporanplgn});
            this.menu_laporan.Name = "menu_laporan";
            this.menu_laporan.Size = new System.Drawing.Size(62, 20);
            this.menu_laporan.Text = "&Laporan";
            // 
            // submenu_laporanbrg
            // 
            this.submenu_laporanbrg.Name = "submenu_laporanbrg";
            this.submenu_laporanbrg.Size = new System.Drawing.Size(176, 22);
            this.submenu_laporanbrg.Text = "&Laporan Barang ";
            // 
            // submenu_laporanplgn
            // 
            this.submenu_laporanplgn.Name = "submenu_laporanplgn";
            this.submenu_laporanplgn.Size = new System.Drawing.Size(176, 22);
            this.submenu_laporanplgn.Text = "&Laporan Pelanggan";
            // 
            // menu_pengaturan
            // 
            this.menu_pengaturan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_ubahpw,
            this.submenu_tambahpengguna});
            this.menu_pengaturan.Name = "menu_pengaturan";
            this.menu_pengaturan.Size = new System.Drawing.Size(80, 20);
            this.menu_pengaturan.Text = "&Pengaturan";
            // 
            // submenu_ubahpw
            // 
            this.submenu_ubahpw.Name = "submenu_ubahpw";
            this.submenu_ubahpw.Size = new System.Drawing.Size(173, 22);
            this.submenu_ubahpw.Text = "&Ubah Password";
            // 
            // submenu_tambahpengguna
            // 
            this.submenu_tambahpengguna.Name = "submenu_tambahpengguna";
            this.submenu_tambahpengguna.Size = new System.Drawing.Size(173, 22);
            this.submenu_tambahpengguna.Text = "&Tambah Pengguna";
            // 
            // menu_tentang
            // 
            this.menu_tentang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_info});
            this.menu_tentang.Name = "menu_tentang";
            this.menu_tentang.Size = new System.Drawing.Size(61, 20);
            this.menu_tentang.Text = "&Tentang";
            // 
            // submenu_info
            // 
            this.submenu_info.Name = "submenu_info";
            this.submenu_info.Size = new System.Drawing.Size(95, 22);
            this.submenu_info.Text = "&Info";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbar_barang,
            this.toolbar_pelanggan,
            this.toolStripSeparator1,
            this.toolbar_transaksi});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolbar_barang
            // 
            this.toolbar_barang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_barang.Image = global::Penjualan_App.Properties.Resources.Shopping_cart;
            this.toolbar_barang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_barang.Name = "toolbar_barang";
            this.toolbar_barang.Size = new System.Drawing.Size(23, 22);
            this.toolbar_barang.ToolTipText = "Data Barang";
            // 
            // toolbar_pelanggan
            // 
            this.toolbar_pelanggan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_pelanggan.Image = global::Penjualan_App.Properties.Resources.User_group;
            this.toolbar_pelanggan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_pelanggan.Name = "toolbar_pelanggan";
            this.toolbar_pelanggan.Size = new System.Drawing.Size(23, 22);
            this.toolbar_pelanggan.ToolTipText = "Data Pelanggan";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbar_transaksi
            // 
            this.toolbar_transaksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbar_transaksi.Image = global::Penjualan_App.Properties.Resources.Calculator;
            this.toolbar_transaksi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbar_transaksi.Name = "toolbar_transaksi";
            this.toolbar_transaksi.Size = new System.Drawing.Size(23, 22);
            this.toolbar_transaksi.ToolTipText = "Data Transaksi";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(147, 17);
            this.toolStripStatusLabel.Text = "Create By Rezki Ramadhan";
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Penjualan_App.Properties.Resources.bck_shop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem menu_file;
        public System.Windows.Forms.ToolStripMenuItem submenu_login;
        public System.Windows.Forms.ToolStripMenuItem submenu_logout;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem submenu_keluar;
        public System.Windows.Forms.ToolStripMenuItem menu_barang;
        public System.Windows.Forms.ToolStripMenuItem submenu_barang;
        public System.Windows.Forms.ToolStripMenuItem submenu_pelanggan;
        public System.Windows.Forms.ToolStripMenuItem menu_transaksi;
        public System.Windows.Forms.ToolStripMenuItem menu_laporan;
        public System.Windows.Forms.ToolStripMenuItem menu_pengaturan;
        public System.Windows.Forms.ToolStripMenuItem menu_tentang;
        public System.Windows.Forms.ToolStripMenuItem submenu_penjualan;
        public System.Windows.Forms.ToolStripMenuItem submenu_laporanbrg;
        public System.Windows.Forms.ToolStripMenuItem submenu_laporanplgn;
        public System.Windows.Forms.ToolStripMenuItem submenu_ubahpw;
        public System.Windows.Forms.ToolStripMenuItem submenu_tambahpengguna;
        public System.Windows.Forms.ToolStripMenuItem submenu_info;
        public System.Windows.Forms.ToolStripButton toolbar_barang;
        public System.Windows.Forms.ToolStripButton toolbar_pelanggan;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton toolbar_transaksi;
    }
}



