
namespace SqlBaglantiUyg
{
    partial class FrmStok
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
            this.stokListe = new System.Windows.Forms.ListView();
            this.stokId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stokKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stokAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stokBirim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stokBarKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stokMiktar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alisFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.satisFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kaydetButon = new System.Windows.Forms.Button();
            this.silButon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stokKodText = new System.Windows.Forms.TextBox();
            this.stokAdiText = new System.Windows.Forms.TextBox();
            this.birimKomBox = new System.Windows.Forms.ComboBox();
            this.barkodText = new System.Windows.Forms.TextBox();
            this.stokMiktariText = new System.Windows.Forms.TextBox();
            this.alisNumeric = new System.Windows.Forms.NumericUpDown();
            this.satisNumeric = new System.Windows.Forms.NumericUpDown();
            this.temizleButon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alisNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Listesi";
            // 
            // stokListe
            // 
            this.stokListe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stokListe.CheckBoxes = true;
            this.stokListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stokId,
            this.stokKod,
            this.stokAdi,
            this.stokBirim,
            this.stokBarKod,
            this.stokMiktar,
            this.alisFiyati,
            this.satisFiyat});
            this.stokListe.FullRowSelect = true;
            this.stokListe.GridLines = true;
            this.stokListe.HideSelection = false;
            this.stokListe.Location = new System.Drawing.Point(6, 27);
            this.stokListe.Name = "stokListe";
            this.stokListe.Size = new System.Drawing.Size(1458, 401);
            this.stokListe.TabIndex = 1;
            this.stokListe.UseCompatibleStateImageBehavior = false;
            this.stokListe.View = System.Windows.Forms.View.Details;
            this.stokListe.DoubleClick += new System.EventHandler(this.stokListe_DoubleClick);
            // 
            // stokId
            // 
            this.stokId.Text = "";
            this.stokId.Width = 23;
            // 
            // stokKod
            // 
            this.stokKod.Text = "Stok Kodu";
            this.stokKod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stokKod.Width = 150;
            // 
            // stokAdi
            // 
            this.stokAdi.Text = "Stok Adı";
            this.stokAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stokAdi.Width = 150;
            // 
            // stokBirim
            // 
            this.stokBirim.Text = "Birim";
            this.stokBirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stokBirim.Width = 100;
            // 
            // stokBarKod
            // 
            this.stokBarKod.Text = "Barkod";
            this.stokBarKod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stokBarKod.Width = 100;
            // 
            // stokMiktar
            // 
            this.stokMiktar.Text = "Stok Miktarı";
            this.stokMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.stokMiktar.Width = 100;
            // 
            // alisFiyati
            // 
            this.alisFiyati.Text = "Alış Fiyatı";
            this.alisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.alisFiyati.Width = 100;
            // 
            // satisFiyat
            // 
            this.satisFiyat.Text = "Satış Fiyat";
            this.satisFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.satisFiyat.Width = 100;
            // 
            // kaydetButon
            // 
            this.kaydetButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetButon.Location = new System.Drawing.Point(432, 12);
            this.kaydetButon.Name = "kaydetButon";
            this.kaydetButon.Size = new System.Drawing.Size(222, 57);
            this.kaydetButon.TabIndex = 2;
            this.kaydetButon.Text = "KAYDET";
            this.kaydetButon.UseVisualStyleBackColor = true;
            this.kaydetButon.Click += new System.EventHandler(this.kaydetButon_Click);
            // 
            // silButon
            // 
            this.silButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButon.Location = new System.Drawing.Point(694, 12);
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(222, 57);
            this.silButon.TabIndex = 3;
            this.silButon.Text = "SİL";
            this.silButon.UseVisualStyleBackColor = true;
            this.silButon.Click += new System.EventHandler(this.silButon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stokListe);
            this.groupBox1.Location = new System.Drawing.Point(12, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1470, 446);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stok Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stok Kodu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stok Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(384, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(384, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Barkod";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(730, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stok Miktarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1134, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Alış Fiyatı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(1116, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "Satış Fiyatı";
            // 
            // stokKodText
            // 
            this.stokKodText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokKodText.Location = new System.Drawing.Point(176, 107);
            this.stokKodText.Name = "stokKodText";
            this.stokKodText.Size = new System.Drawing.Size(174, 38);
            this.stokKodText.TabIndex = 12;
            // 
            // stokAdiText
            // 
            this.stokAdiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokAdiText.Location = new System.Drawing.Point(176, 151);
            this.stokAdiText.Name = "stokAdiText";
            this.stokAdiText.Size = new System.Drawing.Size(174, 38);
            this.stokAdiText.TabIndex = 13;
            // 
            // birimKomBox
            // 
            this.birimKomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.birimKomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birimKomBox.FormattingEnabled = true;
            this.birimKomBox.Items.AddRange(new object[] {
            "Adet",
            "Kutu",
            "Kilogram",
            "Litre"});
            this.birimKomBox.Location = new System.Drawing.Point(507, 107);
            this.birimKomBox.Name = "birimKomBox";
            this.birimKomBox.Size = new System.Drawing.Size(183, 39);
            this.birimKomBox.TabIndex = 14;
            // 
            // barkodText
            // 
            this.barkodText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodText.Location = new System.Drawing.Point(507, 151);
            this.barkodText.MaxLength = 13;
            this.barkodText.Name = "barkodText";
            this.barkodText.Size = new System.Drawing.Size(183, 38);
            this.barkodText.TabIndex = 15;
            // 
            // stokMiktariText
            // 
            this.stokMiktariText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokMiktariText.Location = new System.Drawing.Point(911, 107);
            this.stokMiktariText.Name = "stokMiktariText";
            this.stokMiktariText.Size = new System.Drawing.Size(183, 38);
            this.stokMiktariText.TabIndex = 16;
            // 
            // alisNumeric
            // 
            this.alisNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alisNumeric.Location = new System.Drawing.Point(1308, 108);
            this.alisNumeric.Name = "alisNumeric";
            this.alisNumeric.Size = new System.Drawing.Size(120, 38);
            this.alisNumeric.TabIndex = 19;
            // 
            // satisNumeric
            // 
            this.satisNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisNumeric.Location = new System.Drawing.Point(1308, 152);
            this.satisNumeric.Name = "satisNumeric";
            this.satisNumeric.Size = new System.Drawing.Size(120, 38);
            this.satisNumeric.TabIndex = 20;
            // 
            // temizleButon
            // 
            this.temizleButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizleButon.Location = new System.Drawing.Point(956, 12);
            this.temizleButon.Name = "temizleButon";
            this.temizleButon.Size = new System.Drawing.Size(222, 57);
            this.temizleButon.TabIndex = 21;
            this.temizleButon.Text = "TEMİZLE";
            this.temizleButon.UseVisualStyleBackColor = true;
            this.temizleButon.Click += new System.EventHandler(this.temizleButon_Click);
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 671);
            this.Controls.Add(this.temizleButon);
            this.Controls.Add(this.satisNumeric);
            this.Controls.Add(this.alisNumeric);
            this.Controls.Add(this.stokMiktariText);
            this.Controls.Add(this.barkodText);
            this.Controls.Add(this.birimKomBox);
            this.Controls.Add(this.stokAdiText);
            this.Controls.Add(this.stokKodText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.silButon);
            this.Controls.Add(this.kaydetButon);
            this.Controls.Add(this.label1);
            this.Name = "FrmStok";
            this.Text = "FrmStok";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alisNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satisNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView stokListe;
        private System.Windows.Forms.ColumnHeader stokId;
        private System.Windows.Forms.ColumnHeader stokKod;
        private System.Windows.Forms.ColumnHeader stokAdi;
        private System.Windows.Forms.ColumnHeader stokBirim;
        private System.Windows.Forms.ColumnHeader stokBarKod;
        private System.Windows.Forms.ColumnHeader stokMiktar;
        private System.Windows.Forms.ColumnHeader alisFiyati;
        private System.Windows.Forms.ColumnHeader satisFiyat;
        private System.Windows.Forms.Button kaydetButon;
        private System.Windows.Forms.Button silButon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stokKodText;
        private System.Windows.Forms.TextBox stokAdiText;
        private System.Windows.Forms.ComboBox birimKomBox;
        private System.Windows.Forms.TextBox barkodText;
        private System.Windows.Forms.TextBox stokMiktariText;
        private System.Windows.Forms.NumericUpDown alisNumeric;
        private System.Windows.Forms.NumericUpDown satisNumeric;
        private System.Windows.Forms.Button temizleButon;
    }
}