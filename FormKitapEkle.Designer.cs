namespace WinFormKOS
{
    partial class FormKitapEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.txtKayitNo = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.cbbYazarAdi = new System.Windows.Forms.ComboBox();
            this.cbbYayinevi = new System.Windows.Forms.ComboBox();
            this.txtBasimYil = new System.Windows.Forms.TextBox();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.cbbTur = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cbbDolap = new System.Windows.Forms.ComboBox();
            this.txtRaf = new System.Windows.Forms.TextBox();
            this.txtSira = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.txtFiltrele = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt No:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitabın Adı:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yazar Adı:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yayınevi:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Basım Yılı:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sayfa Sayısı:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Türü:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 280);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Açıklama:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 335);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dolap:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 371);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Raf:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 412);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sıra:";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.txtKayitNo, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.txtKitapAdi, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.cbbYazarAdi, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.cbbYayinevi, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtBasimYil, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.txtSayfaSayisi, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.cbbTur, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.txtAciklama, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.cbbDolap, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.txtRaf, 1, 9);
            this.tableLayoutPanel.Controls.Add(this.txtSira, 1, 10);
            this.tableLayoutPanel.Location = new System.Drawing.Point(16, 15);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 11;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(333, 443);
            this.tableLayoutPanel.TabIndex = 11;
            // 
            // txtKayitNo
            // 
            this.txtKayitNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKayitNo.Location = new System.Drawing.Point(120, 7);
            this.txtKayitNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtKayitNo.Name = "txtKayitNo";
            this.txtKayitNo.ReadOnly = true;
            this.txtKayitNo.Size = new System.Drawing.Size(208, 22);
            this.txtKayitNo.TabIndex = 11;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKitapAdi.Location = new System.Drawing.Point(120, 43);
            this.txtKitapAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(208, 22);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // cbbYazarAdi
            // 
            this.cbbYazarAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbYazarAdi.FormattingEnabled = true;
            this.cbbYazarAdi.Location = new System.Drawing.Point(120, 77);
            this.cbbYazarAdi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbYazarAdi.Name = "cbbYazarAdi";
            this.cbbYazarAdi.Size = new System.Drawing.Size(208, 24);
            this.cbbYazarAdi.TabIndex = 1;
            // 
            // cbbYayinevi
            // 
            this.cbbYayinevi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbYayinevi.FormattingEnabled = true;
            this.cbbYayinevi.Location = new System.Drawing.Point(120, 113);
            this.cbbYayinevi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbYayinevi.Name = "cbbYayinevi";
            this.cbbYayinevi.Size = new System.Drawing.Size(208, 24);
            this.cbbYayinevi.TabIndex = 2;
            // 
            // txtBasimYil
            // 
            this.txtBasimYil.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBasimYil.Location = new System.Drawing.Point(120, 151);
            this.txtBasimYil.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasimYil.Name = "txtBasimYil";
            this.txtBasimYil.Size = new System.Drawing.Size(208, 22);
            this.txtBasimYil.TabIndex = 3;
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSayfaSayisi.Location = new System.Drawing.Point(120, 187);
            this.txtSayfaSayisi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(208, 22);
            this.txtSayfaSayisi.TabIndex = 4;
            // 
            // cbbTur
            // 
            this.cbbTur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbTur.FormattingEnabled = true;
            this.cbbTur.Location = new System.Drawing.Point(120, 221);
            this.cbbTur.Margin = new System.Windows.Forms.Padding(4);
            this.cbbTur.Name = "cbbTur";
            this.cbbTur.Size = new System.Drawing.Size(208, 24);
            this.cbbTur.TabIndex = 5;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAciklama.Location = new System.Drawing.Point(120, 256);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(208, 66);
            this.txtAciklama.TabIndex = 6;
            // 
            // cbbDolap
            // 
            this.cbbDolap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbbDolap.FormattingEnabled = true;
            this.cbbDolap.Location = new System.Drawing.Point(120, 331);
            this.cbbDolap.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDolap.Name = "cbbDolap";
            this.cbbDolap.Size = new System.Drawing.Size(208, 24);
            this.cbbDolap.TabIndex = 7;
            // 
            // txtRaf
            // 
            this.txtRaf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRaf.Location = new System.Drawing.Point(120, 369);
            this.txtRaf.Margin = new System.Windows.Forms.Padding(4);
            this.txtRaf.Name = "txtRaf";
            this.txtRaf.Size = new System.Drawing.Size(208, 22);
            this.txtRaf.TabIndex = 8;
            // 
            // txtSira
            // 
            this.txtSira.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSira.Location = new System.Drawing.Point(120, 409);
            this.txtSira.Margin = new System.Windows.Forms.Padding(4);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(208, 22);
            this.txtSira.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnKaydet, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSil, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTemizle, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 465);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(333, 37);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKaydet.Location = new System.Drawing.Point(4, 4);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(103, 29);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSil.Location = new System.Drawing.Point(115, 4);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 29);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTemizle.Location = new System.Drawing.Point(226, 4);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(103, 29);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg.BackgroundColor = System.Drawing.Color.OldLace;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(359, 15);
            this.dg.Margin = new System.Windows.Forms.Padding(4);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowHeadersVisible = false;
            this.dg.RowHeadersWidth = 51;
            this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg.Size = new System.Drawing.Size(737, 506);
            this.dg.TabIndex = 13;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // txtFiltrele
            // 
            this.txtFiltrele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltrele.Location = new System.Drawing.Point(965, 528);
            this.txtFiltrele.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltrele.Name = "txtFiltrele";
            this.txtFiltrele.Size = new System.Drawing.Size(199, 22);
            this.txtFiltrele.TabIndex = 17;
            this.txtFiltrele.TextChanged += new System.EventHandler(this.txtFiltrele_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(835, 533);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Filtrele:";
            // 
            // FormKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1112, 567);
            this.Controls.Add(this.txtFiltrele);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.FormKitapEkle_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TextBox txtKayitNo;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.ComboBox cbbYazarAdi;
        private System.Windows.Forms.ComboBox cbbYayinevi;
        private System.Windows.Forms.TextBox txtBasimYil;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.ComboBox cbbTur;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cbbDolap;
        private System.Windows.Forms.TextBox txtRaf;
        private System.Windows.Forms.TextBox txtSira;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TextBox txtFiltrele;
        private System.Windows.Forms.Label label12;
    }
}