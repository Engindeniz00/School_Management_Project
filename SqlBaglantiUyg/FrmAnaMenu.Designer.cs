
namespace SqlBaglantiUyg
{
    partial class FrmAnaMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.StoklarButon = new System.Windows.Forms.Button();
            this.ButonOgr = new System.Windows.Forms.Button();
            this.kullanicilarButon = new System.Windows.Forms.Button();
            this.versionText = new System.Windows.Forms.Label();
            this.kullaniciTextBox = new System.Windows.Forms.Label();
            this.TimeText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "ANA MENÜ";
            // 
            // StoklarButon
            // 
            this.StoklarButon.Location = new System.Drawing.Point(24, 132);
            this.StoklarButon.Name = "StoklarButon";
            this.StoklarButon.Size = new System.Drawing.Size(188, 97);
            this.StoklarButon.TabIndex = 1;
            this.StoklarButon.Text = "Stoklar";
            this.StoklarButon.UseVisualStyleBackColor = true;
            this.StoklarButon.Click += new System.EventHandler(this.StoklarButon_Click);
            // 
            // ButonOgr
            // 
            this.ButonOgr.Location = new System.Drawing.Point(262, 132);
            this.ButonOgr.Name = "ButonOgr";
            this.ButonOgr.Size = new System.Drawing.Size(188, 97);
            this.ButonOgr.TabIndex = 2;
            this.ButonOgr.Text = "Öğrenciler";
            this.ButonOgr.UseVisualStyleBackColor = true;
            this.ButonOgr.Click += new System.EventHandler(this.ButonOgr_Click);
            // 
            // kullanicilarButon
            // 
            this.kullanicilarButon.Location = new System.Drawing.Point(507, 132);
            this.kullanicilarButon.Name = "kullanicilarButon";
            this.kullanicilarButon.Size = new System.Drawing.Size(188, 97);
            this.kullanicilarButon.TabIndex = 3;
            this.kullanicilarButon.Text = "Kullanıcılar";
            this.kullanicilarButon.UseVisualStyleBackColor = true;
            this.kullanicilarButon.Click += new System.EventHandler(this.kullanicilarButon_Click);
            // 
            // versionText
            // 
            this.versionText.AutoSize = true;
            this.versionText.BackColor = System.Drawing.SystemColors.Control;
            this.versionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.versionText.Location = new System.Drawing.Point(0, 345);
            this.versionText.Name = "versionText";
            this.versionText.Size = new System.Drawing.Size(155, 25);
            this.versionText.TabIndex = 4;
            this.versionText.Text = "version : 1.0.0 ";
            // 
            // kullaniciTextBox
            // 
            this.kullaniciTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.kullaniciTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kullaniciTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciTextBox.Location = new System.Drawing.Point(190, 315);
            this.kullaniciTextBox.Name = "kullaniciTextBox";
            this.kullaniciTextBox.Size = new System.Drawing.Size(276, 40);
            this.kullaniciTextBox.TabIndex = 5;
            this.kullaniciTextBox.Text = "KullaniciOrnek";
            this.kullaniciTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeText
            // 
            this.TimeText.BackColor = System.Drawing.Color.LightBlue;
            this.TimeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TimeText.Location = new System.Drawing.Point(488, 315);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(207, 40);
            this.TimeText.TabIndex = 6;
            this.TimeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(280, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(569, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Saat";
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 370);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.kullaniciTextBox);
            this.Controls.Add(this.versionText);
            this.Controls.Add(this.kullanicilarButon);
            this.Controls.Add(this.ButonOgr);
            this.Controls.Add(this.StoklarButon);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmAnaMenu";
            this.Text = "FrmAnaMenu";
            this.Load += new System.EventHandler(this.FrmAnaMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StoklarButon;
        private System.Windows.Forms.Button ButonOgr;
        private System.Windows.Forms.Button kullanicilarButon;
        private System.Windows.Forms.Label versionText;
        private System.Windows.Forms.Label kullaniciTextBox;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}