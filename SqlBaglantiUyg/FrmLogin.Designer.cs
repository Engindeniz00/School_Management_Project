
namespace SqlBaglantiUyg
{
    partial class FrmLogin
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
            this.SifreText = new System.Windows.Forms.TextBox();
            this.GiriButon = new System.Windows.Forms.Button();
            this.CikisButon = new System.Windows.Forms.Button();
            this.kullaniciKomboBox = new System.Windows.Forms.ComboBox();
            this.SifreDegLink = new System.Windows.Forms.LinkLabel();
            this.hatirlaCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // SifreText
            // 
            this.SifreText.Location = new System.Drawing.Point(238, 95);
            this.SifreText.Name = "SifreText";
            this.SifreText.PasswordChar = '*';
            this.SifreText.Size = new System.Drawing.Size(229, 34);
            this.SifreText.TabIndex = 3;
            // 
            // GiriButon
            // 
            this.GiriButon.Location = new System.Drawing.Point(59, 205);
            this.GiriButon.Name = "GiriButon";
            this.GiriButon.Size = new System.Drawing.Size(192, 54);
            this.GiriButon.TabIndex = 4;
            this.GiriButon.Text = "GİRİŞ YAP";
            this.GiriButon.UseVisualStyleBackColor = true;
            this.GiriButon.Click += new System.EventHandler(this.GiriButon_Click);
            // 
            // CikisButon
            // 
            this.CikisButon.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CikisButon.Location = new System.Drawing.Point(275, 205);
            this.CikisButon.Name = "CikisButon";
            this.CikisButon.Size = new System.Drawing.Size(192, 54);
            this.CikisButon.TabIndex = 5;
            this.CikisButon.Text = "ÇIKIŞ";
            this.CikisButon.UseVisualStyleBackColor = true;
            this.CikisButon.Click += new System.EventHandler(this.CikisButon_Click);
            // 
            // kullaniciKomboBox
            // 
            this.kullaniciKomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kullaniciKomboBox.FormattingEnabled = true;
            this.kullaniciKomboBox.Location = new System.Drawing.Point(238, 40);
            this.kullaniciKomboBox.Name = "kullaniciKomboBox";
            this.kullaniciKomboBox.Size = new System.Drawing.Size(229, 37);
            this.kullaniciKomboBox.TabIndex = 20;
            this.kullaniciKomboBox.SelectedIndexChanged += new System.EventHandler(this.kullaniciKomboBox_SelectedIndexChanged);
            // 
            // SifreDegLink
            // 
            this.SifreDegLink.AutoSize = true;
            this.SifreDegLink.Location = new System.Drawing.Point(273, 152);
            this.SifreDegLink.Name = "SifreDegLink";
            this.SifreDegLink.Size = new System.Drawing.Size(194, 29);
            this.SifreDegLink.TabIndex = 7;
            this.SifreDegLink.TabStop = true;
            this.SifreDegLink.Text = "Şifremi Değiştir";
            this.SifreDegLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // hatirlaCheckBox
            // 
            this.hatirlaCheckBox.AutoSize = true;
            this.hatirlaCheckBox.Location = new System.Drawing.Point(59, 151);
            this.hatirlaCheckBox.Name = "hatirlaCheckBox";
            this.hatirlaCheckBox.Size = new System.Drawing.Size(171, 33);
            this.hatirlaCheckBox.TabIndex = 8;
            this.hatirlaCheckBox.Text = "Beni Hatırla";
            this.hatirlaCheckBox.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.GiriButon;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CikisButon;
            this.ClientSize = new System.Drawing.Size(528, 285);
            this.Controls.Add(this.hatirlaCheckBox);
            this.Controls.Add(this.SifreDegLink);
            this.Controls.Add(this.CikisButon);
            this.Controls.Add(this.GiriButon);
            this.Controls.Add(this.SifreText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullaniciKomboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SifreText;
        private System.Windows.Forms.Button GiriButon;
        private System.Windows.Forms.Button CikisButon;
        private System.Windows.Forms.LinkLabel SifreDegLink;
        private System.Windows.Forms.CheckBox hatirlaCheckBox;
        private System.Windows.Forms.ComboBox kullaniciKomboBox;
    }
}