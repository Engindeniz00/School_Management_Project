using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SqlBaglantiUyg
{
    public partial class FrmSifreDegisim : Form
    {
        public FrmSifreDegisim()
        {
            InitializeComponent();
        }

        SqlConnection sqlBaglanti = new SqlConnection("Data Source=DESKTOP-7SDHT04;Initial Catalog=OGRENCIYONETIMSISTEMI;Integrated Security=True");
        Islemler islemler = new Islemler();
        private void FrmSifreDegisim_Load(object sender, EventArgs e)
        {
            DataTable dtTable = islemler.Kullanicilar();      
            KullaniciComBox.DataSource = dtTable;
            KullaniciComBox.DisplayMember = "KullaniciAdi";
            KullaniciComBox.ValueMember = "Id";

            if (!string.IsNullOrEmpty(Utils.SifreDegisimKullanici))
            {
                KullaniciComBox.Text = Utils.SifreDegisimKullanici;
            }
            else
            {
                KullaniciComBox.SelectedIndex = -1;
            }
            
            EskSifre.Focus();
             
        }

        private void IptalButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnaylaButon_Click(object sender, EventArgs e)
        {
            int _kulId = Convert.ToInt32(((DataTable)KullaniciComBox.DataSource).Rows[KullaniciComBox.SelectedIndex]["Id"].ToString());
             
            if (EskiSifreKontrol())
            {
               if(YeniSifreText.TextLength>=3 && YeniSifreText.TextLength <= 6)
                {
                    if (YeniSifreText.Text == YenSifTekrarText.Text)
                    {
                        if (sqlBaglanti.State == ConnectionState.Closed)
                            sqlBaglanti.Open();
                        SqlCommand sqlCommand = new SqlCommand("UPDATE Kullanicilar SET Sifre=@_sifre WHERE Id=@_id", sqlBaglanti);
                        sqlCommand.Parameters.AddWithValue("@_id", _kulId);
                        sqlCommand.Parameters.AddWithValue("@_sifre", YeniSifreText.Text);
                        sqlCommand.ExecuteNonQuery();
                        if (sqlBaglanti.State == ConnectionState.Open)
                            sqlBaglanti.Close();
                        MessageBox.Show("Sifre degistirildi");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Yeni şifre ile eski şifre birbiri ile aynı olmalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Şifreniz 3 ile 6 karakter uzunluğunda olmalıdır","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Eski şifreyi yanlış girdiniz");
            }
           
        }

        private bool EskiSifreKontrol()
        {
            string secilenKullaniciSifresi = ((DataTable)KullaniciComBox.DataSource).Rows[KullaniciComBox.SelectedIndex]["Sifre"].ToString();

            if (EskSifre.Text != secilenKullaniciSifresi)
            {
                return false;
            }

            return true;
        }
    }
}
