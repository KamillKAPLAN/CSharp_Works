namespace Kafe_Restorant_Yonetim_Sistemi
{
    partial class frmMasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasa));
            this.btnUrunler = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lstSepet = new System.Windows.Forms.ListView();
            this.grpSepet = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.grpUrun = new System.Windows.Forms.GroupBox();
            this.btnHesapOde = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParaUstu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVerilenMiktar = new System.Windows.Forms.TextBox();
            this.comboOdemeTuru = new System.Windows.Forms.ComboBox();
            this.grpSepet.SuspendLayout();
            this.grpUrun.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUrunler
            // 
            this.btnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunler.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.Location = new System.Drawing.Point(16, 11);
            this.btnUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(31, 159);
            this.btnUrunler.TabIndex = 0;
            this.btnUrunler.Text = "Ürün";
            this.btnUrunler.UseVisualStyleBackColor = true;
            // 
            // lstUrunler
            // 
            this.lstUrunler.LargeImageList = this.imageList1;
            this.lstUrunler.Location = new System.Drawing.Point(8, 17);
            this.lstUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.lstUrunler.MultiSelect = false;
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(361, 628);
            this.lstUrunler.TabIndex = 1;
            this.lstUrunler.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lstSepet
            // 
            this.lstSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSepet.LargeImageList = this.imageList1;
            this.lstSepet.Location = new System.Drawing.Point(4, 19);
            this.lstSepet.Margin = new System.Windows.Forms.Padding(4);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(315, 623);
            this.lstSepet.TabIndex = 4;
            this.lstSepet.UseCompatibleStateImageBehavior = false;
            this.lstSepet.DoubleClick += new System.EventHandler(this.lstSepet_DoubleClick);
            // 
            // grpSepet
            // 
            this.grpSepet.Controls.Add(this.lstSepet);
            this.grpSepet.Location = new System.Drawing.Point(520, 18);
            this.grpSepet.Margin = new System.Windows.Forms.Padding(4);
            this.grpSepet.Name = "grpSepet";
            this.grpSepet.Padding = new System.Windows.Forms.Padding(4);
            this.grpSepet.Size = new System.Drawing.Size(323, 646);
            this.grpSepet.TabIndex = 6;
            this.grpSepet.TabStop = false;
            this.grpSepet.Text = "Sepet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(296, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "₺";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Toplam Tutar:";
            // 
            // txtToplam
            // 
            this.txtToplam.BackColor = System.Drawing.Color.White;
            this.txtToplam.Enabled = false;
            this.txtToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplam.Location = new System.Drawing.Point(191, 42);
            this.txtToplam.Margin = new System.Windows.Forms.Padding(4);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(96, 26);
            this.txtToplam.TabIndex = 5;
            this.txtToplam.Text = "0,0";
            this.txtToplam.TextChanged += new System.EventHandler(this.txtToplam_TextChanged);
            // 
            // grpUrun
            // 
            this.grpUrun.Controls.Add(this.lstUrunler);
            this.grpUrun.Location = new System.Drawing.Point(61, 11);
            this.grpUrun.Margin = new System.Windows.Forms.Padding(4);
            this.grpUrun.Name = "grpUrun";
            this.grpUrun.Padding = new System.Windows.Forms.Padding(4);
            this.grpUrun.Size = new System.Drawing.Size(387, 654);
            this.grpUrun.TabIndex = 7;
            this.grpUrun.TabStop = false;
            // 
            // btnHesapOde
            // 
            this.btnHesapOde.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapOde.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapOde.Image")));
            this.btnHesapOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapOde.Location = new System.Drawing.Point(93, 359);
            this.btnHesapOde.Margin = new System.Windows.Forms.Padding(4);
            this.btnHesapOde.Name = "btnHesapOde";
            this.btnHesapOde.Size = new System.Drawing.Size(195, 49);
            this.btnHesapOde.TabIndex = 8;
            this.btnHesapOde.Text = "Hesap Öde";
            this.btnHesapOde.UseVisualStyleBackColor = true;
            this.btnHesapOde.Click += new System.EventHandler(this.btnHesapOde_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(19, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ödeme Türü:";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.Image")));
            this.btnUrunEkle.Location = new System.Drawing.Point(459, 187);
            this.btnUrunEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(53, 49);
            this.btnUrunEkle.TabIndex = 11;
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.Image")));
            this.btnUrunSil.Location = new System.Drawing.Point(459, 245);
            this.btnUrunSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(53, 49);
            this.btnUrunSil.TabIndex = 11;
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.lstSepet_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtParaUstu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtVerilenMiktar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtToplam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnHesapOde);
            this.groupBox1.Controls.Add(this.comboOdemeTuru);
            this.groupBox1.Location = new System.Drawing.Point(864, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(367, 638);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Para Üstü:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(296, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "₺";
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.BackColor = System.Drawing.Color.Red;
            this.txtParaUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParaUstu.ForeColor = System.Drawing.Color.White;
            this.txtParaUstu.Location = new System.Drawing.Point(191, 116);
            this.txtParaUstu.Margin = new System.Windows.Forms.Padding(4);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.ReadOnly = true;
            this.txtParaUstu.Size = new System.Drawing.Size(96, 26);
            this.txtParaUstu.TabIndex = 14;
            this.txtParaUstu.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Verilen Miktar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(296, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "₺";
            // 
            // txtVerilenMiktar
            // 
            this.txtVerilenMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVerilenMiktar.Location = new System.Drawing.Point(191, 80);
            this.txtVerilenMiktar.Margin = new System.Windows.Forms.Padding(4);
            this.txtVerilenMiktar.Name = "txtVerilenMiktar";
            this.txtVerilenMiktar.Size = new System.Drawing.Size(96, 26);
            this.txtVerilenMiktar.TabIndex = 11;
            this.txtVerilenMiktar.TextChanged += new System.EventHandler(this.txtVerilenMiktar_TextChanged);
            this.txtVerilenMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVerilenMiktar_KeyPress);
            // 
            // comboOdemeTuru
            // 
            this.comboOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOdemeTuru.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboOdemeTuru.FormattingEnabled = true;
            this.comboOdemeTuru.Location = new System.Drawing.Point(176, 159);
            this.comboOdemeTuru.Margin = new System.Windows.Forms.Padding(4);
            this.comboOdemeTuru.Name = "comboOdemeTuru";
            this.comboOdemeTuru.Size = new System.Drawing.Size(168, 27);
            this.comboOdemeTuru.TabIndex = 9;
            // 
            // frmMasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.grpUrun);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.grpSepet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMasa_FormClosing);
            this.Load += new System.EventHandler(this.frmMasa_Load);
            this.grpSepet.ResumeLayout(false);
            this.grpUrun.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.ListView lstUrunler;
        private System.Windows.Forms.ListView lstSepet;
        private System.Windows.Forms.GroupBox grpSepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grpUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapOde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtParaUstu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVerilenMiktar;
        private System.Windows.Forms.ComboBox comboOdemeTuru;
    }
}