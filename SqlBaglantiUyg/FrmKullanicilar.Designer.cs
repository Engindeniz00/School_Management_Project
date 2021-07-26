
namespace SqlBaglantiUyg
{
    partial class FrmKullanicilar
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
            this.kullaniciListe = new System.Windows.Forms.ListView();
            this.IdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kullaniciAdiCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sifreCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aktifCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kaydetButon = new System.Windows.Forms.Button();
            this.silButon = new System.Windows.Forms.Button();
            this.aktPsfButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullaniciTextBox = new System.Windows.Forms.TextBox();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.cikisButon = new System.Windows.Forms.Button();
            this.yeniButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcılar";
            // 
            // kullaniciListe
            // 
            this.kullaniciListe.CheckBoxes = true;
            this.kullaniciListe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdCol,
            this.kullaniciAdiCol,
            this.sifreCol,
            this.aktifCol});
            this.kullaniciListe.FullRowSelect = true;
            this.kullaniciListe.GridLines = true;
            this.kullaniciListe.HideSelection = false;
            this.kullaniciListe.Location = new System.Drawing.Point(25, 86);
            this.kullaniciListe.Name = "kullaniciListe";
            this.kullaniciListe.Size = new System.Drawing.Size(459, 312);
            this.kullaniciListe.TabIndex = 1;
            this.kullaniciListe.UseCompatibleStateImageBehavior = false;
            this.kullaniciListe.View = System.Windows.Forms.View.Details;
            this.kullaniciListe.DoubleClick += new System.EventHandler(this.kullaniciListe_DoubleClick);
            // 
            // IdCol
            // 
            this.IdCol.Text = "";
            this.IdCol.Width = 22;
            // 
            // kullaniciAdiCol
            // 
            this.kullaniciAdiCol.Text = "Kullanıcı Adı";
            this.kullaniciAdiCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kullaniciAdiCol.Width = 144;
            // 
            // sifreCol
            // 
            this.sifreCol.Text = "Şifre";
            this.sifreCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sifreCol.Width = 100;
            // 
            // aktifCol
            // 
            this.aktifCol.Text = "Aktif";
            this.aktifCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kaydetButon
            // 
            this.kaydetButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetButon.Location = new System.Drawing.Point(24, 530);
            this.kaydetButon.Name = "kaydetButon";
            this.kaydetButon.Size = new System.Drawing.Size(149, 63);
            this.kaydetButon.TabIndex = 2;
            this.kaydetButon.Text = "Kaydet";
            this.kaydetButon.UseVisualStyleBackColor = true;
            this.kaydetButon.Click += new System.EventHandler(this.kaydetButon_Click);
            // 
            // silButon
            // 
            this.silButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButon.Location = new System.Drawing.Point(179, 530);
            this.silButon.Name = "silButon";
            this.silButon.Size = new System.Drawing.Size(149, 63);
            this.silButon.TabIndex = 3;
            this.silButon.Text = "Sil";
            this.silButon.UseVisualStyleBackColor = true;
            this.silButon.Click += new System.EventHandler(this.silButon_Click);
            // 
            // aktPsfButon
            // 
            this.aktPsfButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aktPsfButon.Location = new System.Drawing.Point(334, 530);
            this.aktPsfButon.Name = "aktPsfButon";
            this.aktPsfButon.Size = new System.Drawing.Size(149, 63);
            this.aktPsfButon.TabIndex = 4;
            this.aktPsfButon.Text = "Aktif / Pasif";
            this.aktPsfButon.UseVisualStyleBackColor = true;
            this.aktPsfButon.Click += new System.EventHandler(this.aktPsfButon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre";
            // 
            // kullaniciTextBox
            // 
            this.kullaniciTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciTextBox.Location = new System.Drawing.Point(239, 427);
            this.kullaniciTextBox.Name = "kullaniciTextBox";
            this.kullaniciTextBox.Size = new System.Drawing.Size(245, 38);
            this.kullaniciTextBox.TabIndex = 7;
            this.kullaniciTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTextBox.Location = new System.Drawing.Point(239, 475);
            this.sifreTextBox.MaxLength = 6;
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.Size = new System.Drawing.Size(245, 38);
            this.sifreTextBox.TabIndex = 8;
            this.sifreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sifreTextBox.TextChanged += new System.EventHandler(this.sifreTextBox_TextChanged);
            // 
            // cikisButon
            // 
            this.cikisButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButon.Location = new System.Drawing.Point(24, 658);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(457, 51);
            this.cikisButon.TabIndex = 9;
            this.cikisButon.Text = "Çıkış";
            this.cikisButon.UseVisualStyleBackColor = true;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // yeniButon
            // 
            this.yeniButon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniButon.Location = new System.Drawing.Point(24, 601);
            this.yeniButon.Name = "yeniButon";
            this.yeniButon.Size = new System.Drawing.Size(457, 51);
            this.yeniButon.TabIndex = 10;
            this.yeniButon.Text = "Yeni";
            this.yeniButon.UseVisualStyleBackColor = true;
            this.yeniButon.Click += new System.EventHandler(this.yeniButon_Click);
            // 
            // FrmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 721);
            this.Controls.Add(this.yeniButon);
            this.Controls.Add(this.cikisButon);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.kullaniciTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aktPsfButon);
            this.Controls.Add(this.silButon);
            this.Controls.Add(this.kaydetButon);
            this.Controls.Add(this.kullaniciListe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmKullanicilar";
            this.Text = "FrmKullanicilar";
            this.Load += new System.EventHandler(this.FrmKullanicilar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView kullaniciListe;
        private System.Windows.Forms.ColumnHeader IdCol;
        private System.Windows.Forms.ColumnHeader kullaniciAdiCol;
        private System.Windows.Forms.ColumnHeader sifreCol;
        private System.Windows.Forms.ColumnHeader aktifCol;
        private System.Windows.Forms.Button kaydetButon;
        private System.Windows.Forms.Button silButon;
        private System.Windows.Forms.Button aktPsfButon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullaniciTextBox;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button yeniButon;
    }
}