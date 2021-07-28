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
        //SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7SDHT04;Initial Catalog=OGRENCIYONETIMSISTEMI;Integrated Security=True");

        private void FrmStok_Load(object sender, EventArgs e)
        {
            Temizle();
            VerileriGosterStok();
        }


        private void VerileriGosterStok()
        {
            DataTable dtStok = Utils.TabloGetir("SELECT * FROM Stok");
             
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
             
        }

        private void kaydetButon_Click(object sender, EventArgs e)
        {
            string sorgu="";
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
                        sorgu = string.Format(@"UPDATE Stok SET StokKodu=@_stokKodu,StokAdi=@_stokAdi,Birim=@_birim,Barkod=@_barkod,StokMiktari=@_stokMiktari,AlisFiyati=@_alisFiyati,SatisFiyati=@_satisFiyati WHERE Id = {0}", Utils.StokItemId);
                    }
                    else
                    {
                        sorgu = string.Format(@"INSERT INTO Stok (StokKodu,StokAdi,Birim,Barkod,StokMiktari,AlisFiyati,SatisFiyati) VALUES ('{0}','{1}','{2}','{3}','{4}',{5},{6})",stokKodText.Text,stokAdiText.Text,birimKomBox.Text,barkodText.Text,stokMiktariText.Text,(float)alisNumeric.Value,(float)satisNumeric.Value);
                    }
                }

            }           

            else
            {
                MessageBox.Show("Lütfen ürün bilgilerini tam doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Utils.SorguCalistir(sorgu))
            {
                MessageBox.Show("İşleminiz tamamlandı.", "Olumlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("HATA!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    //sqlCommand = new SqlCommand("DELETE FROM Stok WHERE Id = @_id",Utils.baglantiOlustur);
                    //sqlCommand.Parameters.AddWithValue("@_id", Convert.ToInt32(item.SubItems[0].Text));
                }
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Ürünü Seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (Utils.baglantiOlustur.State == ConnectionState.Closed)
            //    Utils.baglantiOlustur.Open();
            //sqlCommand.ExecuteNonQuery();
            //if (Utils.baglantiOlustur.State == ConnectionState.Open)
            //    Utils.baglantiOlustur.Close();
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


        // burada barkodumuzu üretiyoruz
        private void BarkodUret()
        {
            string Barrcode, Check12Digits;
            string uretilenBarkod = "";
            Check12Digits =  Utils.KarakterUret();
            Barrcode = EAN13Class.EAN13(Check12Digits);

            // burayı barkodumuzu görselleştirmek için kullanıyoruz. Ama şu an ihtiyacımız yoks
            //barkodText.Text = Barrcode;

            if (!string.Equals(EAN13Class.Barcode13Digits, "") || (EAN13Class.Barcode13Digits != ""))
            {
                uretilenBarkod = EAN13Class.Barcode13Digits.ToString();
            }

            barkodText.Text = uretilenBarkod;

        }

        
        // stok kod text box'ından ayrılır ayrılmaz kodu üretsin
        private void stokKodText_Leave(object sender, EventArgs e)
        {
            BarkodUret();

        }
    }
}
