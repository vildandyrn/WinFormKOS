﻿namespace WinFormKOS
{
    partial class FormEmanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmanet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltreleOkuyucu = new System.Windows.Forms.TextBox();
            this.dgOkuyucular = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.lblOkulNo = new System.Windows.Forms.Label();
            this.lblGecikmeBedeli = new System.Windows.Forms.Label();
            this.pictureProfil = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFiltreleKitap = new System.Windows.Forms.TextBox();
            this.dgKitaplar = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKayitNo = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblYazarAdi = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEmanetEt = new System.Windows.Forms.Button();
            this.btnSureUzat = new System.Windows.Forms.Button();
            this.btnDusumYap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfil)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFiltreleOkuyucu);
            this.groupBox1.Controls.Add(this.dgOkuyucular);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1079, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Okuyucu Seç";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(796, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrele:";
            // 
            // txtFiltreleOkuyucu
            // 
            this.txtFiltreleOkuyucu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltreleOkuyucu.Location = new System.Drawing.Point(871, 214);
            this.txtFiltreleOkuyucu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltreleOkuyucu.Name = "txtFiltreleOkuyucu";
            this.txtFiltreleOkuyucu.Size = new System.Drawing.Size(199, 22);
            this.txtFiltreleOkuyucu.TabIndex = 2;
            this.txtFiltreleOkuyucu.TextChanged += new System.EventHandler(this.txtFiltreleOkuyucu_TextChanged);
            // 
            // dgOkuyucular
            // 
            this.dgOkuyucular.AllowUserToAddRows = false;
            this.dgOkuyucular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOkuyucular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgOkuyucular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgOkuyucular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOkuyucular.Location = new System.Drawing.Point(349, 30);
            this.dgOkuyucular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgOkuyucular.MultiSelect = false;
            this.dgOkuyucular.Name = "dgOkuyucular";
            this.dgOkuyucular.ReadOnly = true;
            this.dgOkuyucular.RowHeadersVisible = false;
            this.dgOkuyucular.RowHeadersWidth = 51;
            this.dgOkuyucular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOkuyucular.Size = new System.Drawing.Size(721, 177);
            this.dgOkuyucular.TabIndex = 1;
            this.dgOkuyucular.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOkuyucular_CellClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureProfil, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 135);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.lblAdSoyad, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSinif, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOkulNo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblGecikmeBedeli, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(111, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(218, 127);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(4, 7);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(69, 17);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblSinif
            // 
            this.lblSinif.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSinif.AutoSize = true;
            this.lblSinif.Location = new System.Drawing.Point(4, 38);
            this.lblSinif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(35, 17);
            this.lblSinif.TabIndex = 1;
            this.lblSinif.Text = "Sınıf";
            // 
            // lblOkulNo
            // 
            this.lblOkulNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOkulNo.AutoSize = true;
            this.lblOkulNo.Location = new System.Drawing.Point(4, 69);
            this.lblOkulNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOkulNo.Name = "lblOkulNo";
            this.lblOkulNo.Size = new System.Drawing.Size(59, 17);
            this.lblOkulNo.TabIndex = 2;
            this.lblOkulNo.Text = "Okul No";
            // 
            // lblGecikmeBedeli
            // 
            this.lblGecikmeBedeli.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGecikmeBedeli.AutoSize = true;
            this.lblGecikmeBedeli.Location = new System.Drawing.Point(4, 101);
            this.lblGecikmeBedeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGecikmeBedeli.Name = "lblGecikmeBedeli";
            this.lblGecikmeBedeli.Size = new System.Drawing.Size(106, 17);
            this.lblGecikmeBedeli.TabIndex = 3;
            this.lblGecikmeBedeli.Text = "Gecikme Bedeli";
            // 
            // pictureProfil
            // 
            this.pictureProfil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureProfil.Image = ((System.Drawing.Image)(resources.GetObject("pictureProfil.Image")));
            this.pictureProfil.Location = new System.Drawing.Point(4, 6);
            this.pictureProfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureProfil.Name = "pictureProfil";
            this.pictureProfil.Size = new System.Drawing.Size(99, 123);
            this.pictureProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProfil.TabIndex = 1;
            this.pictureProfil.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFiltreleKitap);
            this.groupBox2.Controls.Add(this.dgKitaplar);
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(17, 270);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1079, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Seç";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(796, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Filtrele:";
            // 
            // txtFiltreleKitap
            // 
            this.txtFiltreleKitap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltreleKitap.Location = new System.Drawing.Point(871, 208);
            this.txtFiltreleKitap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltreleKitap.Name = "txtFiltreleKitap";
            this.txtFiltreleKitap.Size = new System.Drawing.Size(199, 22);
            this.txtFiltreleKitap.TabIndex = 5;
            this.txtFiltreleKitap.TextChanged += new System.EventHandler(this.txtFiltreleKitap_TextChanged);
            // 
            // dgKitaplar
            // 
            this.dgKitaplar.AllowUserToAddRows = false;
            this.dgKitaplar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKitaplar.Location = new System.Drawing.Point(349, 23);
            this.dgKitaplar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgKitaplar.MultiSelect = false;
            this.dgKitaplar.Name = "dgKitaplar";
            this.dgKitaplar.ReadOnly = true;
            this.dgKitaplar.RowHeadersVisible = false;
            this.dgKitaplar.RowHeadersWidth = 51;
            this.dgKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKitaplar.Size = new System.Drawing.Size(721, 177);
            this.dgKitaplar.TabIndex = 4;
            this.dgKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKitaplar_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblKayitNo, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblKitapAdi, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblYazarAdi, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 23);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(333, 111);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kayıt No";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kitabın Adı";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yazar Adı";
            // 
            // lblKayitNo
            // 
            this.lblKayitNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKayitNo.AutoSize = true;
            this.lblKayitNo.Location = new System.Drawing.Point(111, 10);
            this.lblKayitNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKayitNo.Name = "lblKayitNo";
            this.lblKayitNo.Size = new System.Drawing.Size(20, 17);
            this.lblKayitNo.TabIndex = 3;
            this.lblKayitNo.Text = "...";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(111, 47);
            this.lblKitapAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(20, 17);
            this.lblKitapAdi.TabIndex = 4;
            this.lblKitapAdi.Text = "...";
            // 
            // lblYazarAdi
            // 
            this.lblYazarAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYazarAdi.AutoSize = true;
            this.lblYazarAdi.Location = new System.Drawing.Point(111, 84);
            this.lblYazarAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYazarAdi.Name = "lblYazarAdi";
            this.lblYazarAdi.Size = new System.Drawing.Size(20, 17);
            this.lblYazarAdi.TabIndex = 5;
            this.lblYazarAdi.Text = "...";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.btnEmanetEt, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSureUzat, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnDusumYap, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(763, 523);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(333, 37);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // btnEmanetEt
            // 
            this.btnEmanetEt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmanetEt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmanetEt.Location = new System.Drawing.Point(4, 4);
            this.btnEmanetEt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmanetEt.Name = "btnEmanetEt";
            this.btnEmanetEt.Size = new System.Drawing.Size(103, 29);
            this.btnEmanetEt.TabIndex = 0;
            this.btnEmanetEt.Text = "Emanet Et";
            this.btnEmanetEt.UseVisualStyleBackColor = false;
            this.btnEmanetEt.Click += new System.EventHandler(this.btnEmanetEt_Click);
            // 
            // btnSureUzat
            // 
            this.btnSureUzat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSureUzat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSureUzat.Location = new System.Drawing.Point(115, 4);
            this.btnSureUzat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSureUzat.Name = "btnSureUzat";
            this.btnSureUzat.Size = new System.Drawing.Size(103, 29);
            this.btnSureUzat.TabIndex = 1;
            this.btnSureUzat.Text = "Süre Uzat";
            this.btnSureUzat.UseVisualStyleBackColor = false;
            this.btnSureUzat.Click += new System.EventHandler(this.btnSureUzat_Click);
            // 
            // btnDusumYap
            // 
            this.btnDusumYap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDusumYap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDusumYap.Location = new System.Drawing.Point(226, 4);
            this.btnDusumYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDusumYap.Name = "btnDusumYap";
            this.btnDusumYap.Size = new System.Drawing.Size(103, 29);
            this.btnDusumYap.TabIndex = 2;
            this.btnDusumYap.Text = "Düşüm Yap";
            this.btnDusumYap.UseVisualStyleBackColor = false;
            this.btnDusumYap.Click += new System.EventHandler(this.btnDusumYap_Click);
            // 
            // FormEmanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1112, 567);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEmanet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet İşlemleri";
            this.Load += new System.EventHandler(this.FormEmanet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOkuyucular)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfil)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKitaplar)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltreleOkuyucu;
        private System.Windows.Forms.DataGridView dgOkuyucular;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.Label lblOkulNo;
        private System.Windows.Forms.Label lblGecikmeBedeli;
        private System.Windows.Forms.PictureBox pictureProfil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFiltreleKitap;
        private System.Windows.Forms.DataGridView dgKitaplar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKayitNo;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblYazarAdi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnEmanetEt;
        private System.Windows.Forms.Button btnSureUzat;
        private System.Windows.Forms.Button btnDusumYap;
    }
}