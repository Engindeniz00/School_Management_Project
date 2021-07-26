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
    public partial class FrmKullanicilar : Form
    {        
        public FrmKullanicilar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7SDHT04;Initial Catalog=OGRENCIYONETIMSISTEMI;Integrated Security=True");
        string _kullaniciAdi = Utils.KullaniciDegisimAdi;
        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            VerileriGoster();         
            VerileriTemizle();
        }    
        

        private void VerileriGoster()
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Kullanicilar", baglanti);          
            DataTable dtKullanici = new DataTable();
            sqlDataAdapter.Fill(dtKullanici);
            if(dtKullanici!=null && dtKullanici.Rows.Count>0)
            {
                kullaniciListe.Items.Clear();
                for (int i = 0; i < dtKullanici.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dtKullanici.Rows[i]["Id"].ToString();
                    item.SubItems.Add(dtKullanici.Rows[i]["KullaniciAdi"].ToString());
                    item.SubItems.Add(dtKullanici.Rows[i]["Sifre"].ToString());
                    if (Convert.ToBoolean(dtKullanici.Rows[i]["Aktif"], null))
                    {
                        item.SubItems.Add("Aktif");
                    }
                    else
                    {
                        item.SubItems.Add("Pasif");
                    }
                    kullaniciListe.Items.Add(item);
                }
            }
            else
            {
                kullaniciListe.Clear();
            }

            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();

        }


        private void BilgiAtama()
        {
            if (kullaniciListe.SelectedItems.Count > 0)
            {
                int _selectedIndex = kullaniciListe.FocusedItem.Index;
                Utils.KullaniciDegisimId = Convert.ToInt32(kullaniciListe.Items[_selectedIndex].SubItems[0].Text);
                kullaniciTextBox.Text = kullaniciListe.Items[_selectedIndex].SubItems[1].Text;
                sifreTextBox.Text = kullaniciListe.Items[_selectedIndex].SubItems[2].Text;
            }
        }

        private void kullaniciListe_DoubleClick(object sender, EventArgs e)
        {
            BilgiAtama();
        }

        private void kaydetButon_Click(object sender, EventArgs e)
        {
            _kullaniciAdi = kullaniciTextBox.Text;
            if (kullaniciTextBox.Text !="")
            {
                SqlCommand sqlCommand=null;
                if (Utils.KullaniciDegisimId > 0)
                {
                     sqlCommand= new SqlCommand("UPDATE Kullanicilar SET KullaniciAdi=@_kullaniciAdi,Sifre=@_sifre WHERE Id=@Id", baglanti);
                    sqlCommand.Parameters.AddWithValue("@Id", Utils.KullaniciDegisimId);
                    sqlCommand.Parameters.AddWithValue("@_kullaniciAdi", kullaniciTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@_sifre", sifreTextBox.Text);
                    MessageBox.Show("Kullanıcı başarılı bir şekilde güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (sifreTextBox.Text.Length >= 3)
                    {
                        if (KontrolKayit(_kullaniciAdi))
                        {
                            sqlCommand = new SqlCommand("INSERT INTO Kullanicilar (KullaniciAdi,Sifre,Aktif) VALUES(@_kullaniciAdi,@_sifre,1)", baglanti);
                            sqlCommand.Parameters.AddWithValue("@_kullaniciAdi", kullaniciTextBox.Text);
                            sqlCommand.Parameters.AddWithValue("@_sifre", sifreTextBox.Text);
                            MessageBox.Show("Yeni kullanıcı başarılı bir şekilde eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("BU KULLANICI ZATEN VAR", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            VerileriTemizle();
                            VerileriGoster();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifre 3 karakterden kısa olamaz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                sqlCommand.ExecuteNonQuery();
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Seçilmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            VerileriTemizle();
            VerileriGoster();
                
        }

        private bool KontrolKayit(string _text)
        {
            bool kont = true;
            int _index = 0;
            foreach (ListViewItem item in kullaniciListe.Items)
            {
                if (item.SubItems[1].Text == _text)
                {
                    _index = item.Index;
                    kont = false;
                }
            }
            if (kont)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void VerileriTemizle ()
        {
            kullaniciTextBox.Clear();
            sifreTextBox.Clear();
            Utils.KullaniciDegisimId = 0;
        }

        private void sifreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sifreTextBox.Text.Length >= 6)
            {
                MessageBox.Show("Şifre 6 karakterden uzun olamaz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void silButon_Click(object sender, EventArgs e)
        {
            
            if (kullaniciListe.CheckedItems.Count > 0)
            {
                foreach (ListViewItem item in kullaniciListe.CheckedItems)
                {
                    if(item.SubItems[0].Text == "1014")
                    {
                        MessageBox.Show("Admin Silinemez!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Kullanicilar WHERE Id=@_Id", baglanti);
                    sqlCommand.Parameters.AddWithValue("@_Id", Convert.ToInt32(item.SubItems[0].Text));                   
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    sqlCommand.ExecuteNonQuery();
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için kullanıcı seçiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            VerileriGoster();           
        }

        private void aktPsfButon_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            if (kullaniciListe.CheckedItems.Count > 0)
            {
                foreach (ListViewItem item in kullaniciListe.CheckedItems)
                {
                    if(item.SubItems[3].Text == "Aktif")
                    {
                        sqlCommand = new SqlCommand("UPDATE Kullanicilar SET Aktif=0 WHERE Id=@_Id", baglanti);
                    }
                    else
                    {
                        sqlCommand = new SqlCommand("UPDATE Kullanicilar SET Aktif=1 WHERE Id=@_Id", baglanti);
                    }
                    sqlCommand.Parameters.AddWithValue("@_Id", Convert.ToInt32(item.SubItems[0].Text));
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    sqlCommand.ExecuteNonQuery();
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcıyı aktif veya pasif yapmak için seçim yapınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            VerileriGoster();
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yeniButon_Click(object sender, EventArgs e)
        {
            FrmKullanicilar_Load(sender,e);
        }
    }
}
