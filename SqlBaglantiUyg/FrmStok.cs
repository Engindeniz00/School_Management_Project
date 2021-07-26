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
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7SDHT04;Initial Catalog=OGRENCIYONETIMSISTEMI;Integrated Security=True");

        private void FrmStok_Load(object sender, EventArgs e)
        {
            Temizle();
            VerileriGosterStok();
        }


        private void VerileriGosterStok()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Stok",baglanti);
            DataTable dtStok = new DataTable();
            sqlDataAdapter.Fill(dtStok);

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            
            if(dtStok !=null && dtStok.Rows.Count > 0)
            {
                stokListe.Items.Clear();
                for (int i = 0; i < dtStok.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dtStok.Rows[i]["Id"].ToString();
                    item.SubItems.Add(dtStok.Rows[i]["StokKodu"].ToString());
                    item.SubItems.Add(dtStok.Rows[i]["StokAdi"].ToString());
                    item.SubItems.Add(dtStok.Rows[i]["Birim"].ToString());
                    item.SubItems.Add(dtStok.Rows[i]["Barkod"].ToString());
                    item.SubItems.Add(dtStok.Rows[i]["StokMiktari"].ToString());
                    item.SubItems.Add(dtStok.Rows[i]["AlisFiyati"].ToString());
                    item.SubItems.Add(dtStok.Rows[i]["SatisFiyati"].ToString());

                    stokListe.Items.Add(item);
                }
            }
            else
            {
                stokListe.Items.Clear();
            }


            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();
        }

        private void kaydetButon_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand=null;
            if (stokKodText.Text != "" && stokAdiText.Text != "" && birimKomBox.Text != "" && barkodText.Text != "" && stokMiktariText.Text != "" && alisNumeric.Value > 0 && satisNumeric.Value > 0)
            {
                if (barkodText.Text.Length < 13)
                {
                    MessageBox.Show("Barkod uzunluğu 13 hane olmalı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (Utils.StokItemId > 0)
                    {
                        sqlCommand = new SqlCommand("UPDATE Stok SET StokKodu=@_stokKodu,StokAdi=@_stokAdi,Birim=@_birim,Barkod=@_barkod,StokMiktari=@_stokMiktari,AlisFiyati=@_alisFiyati,SatisFiyati=@_satisFiyati WHERE Id = @_id",baglanti);
                        sqlCommand.Parameters.AddWithValue("@_id", Utils.StokItemId);

                    }
                    else
                    {
                        sqlCommand = new SqlCommand("INSERT INTO Stok (StokKodu,StokAdi,Birim,Barkod,StokMiktari,AlisFiyati,SatisFiyati) VALUES (@_stokKodu,@_stokAdi,@_birim,@_barkod,@_stokMiktari,@_alisFiyati,@_satisFiyati)", baglanti);
                    }
                }              
                    
                sqlCommand.Parameters.AddWithValue("@_stokKodu", stokKodText.Text);
                sqlCommand.Parameters.AddWithValue("@_stokAdi", stokAdiText.Text);
                sqlCommand.Parameters.AddWithValue("@_birim", birimKomBox.Text);
                sqlCommand.Parameters.AddWithValue("@_barkod", barkodText.Text);
                sqlCommand.Parameters.AddWithValue("@_stokMiktari", stokMiktariText.Text);
                sqlCommand.Parameters.AddWithValue("@_alisFiyati", (float)alisNumeric.Value);
                sqlCommand.Parameters.AddWithValue("@_satisFiyati", (float)satisNumeric.Value);

                    
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                sqlCommand.ExecuteNonQuery();
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();

            }
           
            else
            {
                MessageBox.Show("Lütfen ürün bilgilerini tam doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            VerileriGosterStok();
            Temizle();
        }

        private void Temizle()
        {
            Utils.StokItemId = 0;
            stokAdiText.Clear();
            stokKodText.Clear();
            birimKomBox.SelectedIndex = -1;
            barkodText.Clear();
            stokMiktariText.Clear();
            alisNumeric.Value = 0;
            satisNumeric.Value = 0;

        }

        private void silButon_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = null;
            if (stokListe.CheckedItems.Count > 0)
            {
                foreach(ListViewItem item in stokListe.CheckedItems)
                {
                    sqlCommand = new SqlCommand("DELETE FROM Stok WHERE Id = @_id",baglanti);
                    sqlCommand.Parameters.AddWithValue("@_id", Convert.ToInt32(item.SubItems[0].Text));
                }
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Ürünü Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            sqlCommand.ExecuteNonQuery();
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();
            VerileriGosterStok();
        }

        private void stokListe_DoubleClick(object sender, EventArgs e)
        {
            int _selectedIndex = stokListe.FocusedItem.Index;
            VerileriGetirStok(_selectedIndex);

        }

        private void VerileriGetirStok(int index)
        {
            Utils.StokItemId = Convert.ToInt32(stokListe.Items[index].SubItems[0].Text);
            stokKodText.Text = stokListe.Items[index].SubItems[1].Text;
            stokAdiText.Text = stokListe.Items[index].SubItems[2].Text;
            birimKomBox.Text = stokListe.Items[index].SubItems[3].Text;
            barkodText.Text = stokListe.Items[index].SubItems[4].Text;
            stokMiktariText.Text = stokListe.Items[index].SubItems[5].Text;
            alisNumeric.Value = Convert.ToInt32(stokListe.Items[index].SubItems[6].Text);
            satisNumeric.Value = Convert.ToInt32(stokListe.Items[index].SubItems[7].Text);
        }

        private void temizleButon_Click(object sender, EventArgs e)
        {
            FrmStok_Load(sender,e);
        }
    }
}
