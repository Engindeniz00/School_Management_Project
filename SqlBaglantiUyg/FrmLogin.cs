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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }        
        

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7SDHT04;Initial Catalog=OGRENCIYONETIMSISTEMI;Integrated Security=True");
        Islemler islemler = new Islemler();
        private void GiriButon_Click(object sender, EventArgs e)
        {
           

            // kullanıcı adı kısmı boş ise
            if (kullaniciKomboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Kullanıcı seçmediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                kullaniciKomboBox.Focus();
                return;
            }

            // şifre yazılmamışsa
            if (string.IsNullOrEmpty(SifreText.Text))
            {
                MessageBox.Show("Şifreyi girmediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SifreText.Focus();
                SifreText.SelectAll();
                return;
            }

            /*** eğer şifre ve kullanıcı adı girilmişse kullanıcı komboboxtaki datasource üzerinden bilgiler kullanılarak şifre kontrolu yapılıyor.***/

            //burada kullanicikombobox datasource'unu kullanarak secilen kullanıcı adının bulunduğu satırdaki şifre değerini alıyor.
            string secilenKullaniciSifresi = ((DataTable)kullaniciKomboBox.DataSource).Rows[kullaniciKomboBox.SelectedIndex]["Sifre"].ToString();
            
            if (SifreText.Text== secilenKullaniciSifresi)
            {
                // Burada remember checkbox'ımızdan verileri alıyoruz, eğer checkstate = true ise
                // kullanıcıbox ve sifretext deki değerlerimizi Properties.Settings.Default değerleri 
                // olarak kaydediyor.
                RememberCheckBoxKayit();

                Utils.KullaniciAdi = kullaniciKomboBox.Text;
                /***Bu yöntemle de yapılabilir fakat bir aşağı satırdaki yöntemle çok daha rahat bir şekilde yapılabilir***/
                //Utils.KullaniciId = Convert.ToInt32(((DataTable)kullaniciKomboBox.DataSource).Rows[kullaniciKomboBox.SelectedIndex]["Id"].ToString());
                Utils.KullaniciId = Convert.ToInt32(kullaniciKomboBox.SelectedValue);
                FrmAnaMenu frmAnaMenu = new FrmAnaMenu();
                this.Hide();
                // ShowDialog(); ---> kullanmak daha mantıklı
                frmAnaMenu.ShowDialog();
                this.Show();
            }

            // eğer şifre eşleşmesi olmuyorsa hatalı şifre uyarısı veriyor
            else
            {
                MessageBox.Show("Hatalı şifre girişi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SifreText.Focus();
                SifreText.SelectAll();
                return;
            }
            
            ///***
            // * sql içindeki login listemizde dolaşıyor ve kullanıcı adı ile şifre eşleşirse true eşleşmezse false döndürüyor 
            // * böylece login ekranmızı kullanım fonksiyonunu yerine getirmış oluyoruz.
            // * ***/
            //SqlCommand sifre = new SqlCommand("SELECT CASE WHEN EXISTS (SELECT KullaniciAdi FROM Kullanicilar WHERE Sifre = @Sifre AND KullaniciAdi=@KullaniciAdi ) THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END",baglanti);
            //sifre.Parameters.AddWithValue("@Sifre", SifreText.Text);
            //sifre.Parameters.AddWithValue("@KullaniciAdi", kullaniciKomboBox.Text);
            //if(baglanti.State == ConnectionState.Closed)
            //{
            //    baglanti.Open();
            //}

            //if(kullaniciKomboBox.Text == "(Aktif kullanıcı yok)")
            //{
            //    MessageBox.Show("Aktif Kullanıcı Bulunmamaktadır.");
            //}

            //else if (kullaniciKomboBox.Text != "")
            //{
            //    // burada sql üzerindeki object veri tipindeki veriyi boolean veri tipine dönüştürerek işlemek soktuk
            //    // *** ÖNEMLİ BİR KOD ***
            //    if (Convert.ToBoolean(sifre.ExecuteScalar(), null))
            //    {
            //        FrmOgrenci formOgr = new FrmOgrenci();
            //        formOgr.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Yanlış Şifre!");
            //    }
            //}            
            
            //else
            //{
            //    MessageBox.Show("LÜTFEN KULLANICI ADINI GİRİNİZ!");
            //}
            //if (baglanti.State == ConnectionState.Open)
            //{
            //    baglanti.Close();
            //}
        }

        private void CikisButon_Click(object sender, EventArgs e)
        {
            // direk görev yöneticisinde siliyor fakat Close() sadece formu kapatır
            Application.Exit();
        }
 
        private void FrmLogin_Load(object sender, EventArgs e)
        {           

            DataTable dtAktifler = islemler.Kullanicilar();
            kullaniciKomboBox.DataSource = dtAktifler;

            /***
             * burada kullanıcı tablosundaki KullaniciAdi sütunundaki verileri komboboxun içinde gösteriyor
             * seçilen kullanıcı adının buluduğu satırdaki istediğimiz sütun değerini .ValueMember özelliği ile çağırabiliriz.
             * İlk başta hiçbir kullanıcı adı seçilmediği için kombobox'ı boş göstermesi için SelectedIndex değerini -1 olarak ayarlarız.
             ***/
            // displayde kullanıcı adını göstersin ama value olarak Id numarasını çekebilelim
            kullaniciKomboBox.DisplayMember = "KullaniciAdi";
            kullaniciKomboBox.ValueMember = "Id";
            RememberCheckYazdir();
             
        }

        //Eğer kullanıcı adı kısmında bir seçenek seçili ise direk şifre kutusunu seçsin değilse kombobox'u seçsin
        private void kullaniciKomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (kullaniciKomboBox.SelectedIndex>=0)
            {
                SifreText.Focus();
                
            }
            else
            {
                kullaniciKomboBox.Focus();
            } 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.SifreDegisimKullanici = kullaniciKomboBox.Text;
            FrmSifreDegisim frmSifreDegisim = new FrmSifreDegisim();
            frmSifreDegisim.ShowDialog();
            FrmLogin_Load(sender, e);           
        }

        // burada verileri default olarak kayıt ediyoruz
        private void RememberCheckBoxKayit()
        {
            if (hatirlaCheckBox.Checked)
            {
                Properties.Settings.Default.UserName = kullaniciKomboBox.Text;
                Properties.Settings.Default.Password = SifreText.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();

            }
        }

        private void RememberCheckYazdir()
        {
            // Burada remember checkbox'ımızın durumunu kontrol ediyoruz
            // ardından kayıtlı verileri text kısımlarına atıyoruz.
            if (Properties.Settings.Default.UserName != "")
            {
                if (Properties.Settings.Default.Remember)
                {
                    kullaniciKomboBox.Text = Properties.Settings.Default.UserName;
                    SifreText.Text = Properties.Settings.Default.Password;
                    hatirlaCheckBox.Checked = true;
                }
                else
                {
                    kullaniciKomboBox.SelectedIndex = -1;
                }
            }
            else
            {
                kullaniciKomboBox.SelectedIndex = -1;
            }
        }
    }
}
