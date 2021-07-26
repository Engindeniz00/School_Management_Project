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
using System.IO;

namespace SqlBaglantiUyg
{
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        List<int> listeChecked = new List<int>();

        double ortalama = 0;
        // burada standart sql bağlantımızı sağladık
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7SDHT04;Initial Catalog=OGRENCIYONETIMSISTEMI;Integrated Security=True");
        int KayitId = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            // burada list view ismini kullanarak bağlantı sağlamaya çalışacağız
            VerileriGosterButon_Click(sender, e);
        }

        private void VerileriGosterButon_Click(object sender, EventArgs e)
        {
            VerileriGoster("");            
        }

        private void VerileriGoster(string kriter)
        {

            DataTable dtTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            if (kriter.Length >= 3)
            {
                // burada adi ve soyadini birlikte aldık ve ayrıca arama kutusundaki stringi içeren her veriyi çekme komutu verdik.


                /*** SQL SORGUSUNUN ÖNEMİ ***/
                // burada görüleceği üzere sql sorgularında biri olan join komutlarını kullanarak
                // iki tablo arasında Id bağlantası kurarak verileri tabloya dökebiliyoruz
                sqlDataAdapter.SelectCommand = new SqlCommand(@"SELECT Ogr.Adi+' '+Ogr.Soyadi as AdiSoyadi, Ogr.*, Kl.KullaniciAdi as
                    KaydedenKullaniciAdi, Kl1.KullaniciAdi as DegistirenKullaniciAdi 
                    FROM Ogrenciler AS Ogr
                    INNER JOIN Kullanicilar as Kl on Kl.Id=Ogr.Kaydeden
                    LEFT JOIN Kullanicilar as Kl1 on Kl1.Id=Ogr.Degistiren
                    WHERE Ogr.Adi + ' ' + Ogr.Soyadi like @kriter");

                // önemli bilgi : eğer %example% şeklinde ise herhangi değeri example değeri ile eşleşenlerin hepsini çağırır
                // eğer example% şeklinde ise listeden example ile başlayanları çağırır
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@kriter", "%" + kriter + "%");
            }
            else
            {
                sqlDataAdapter.SelectCommand = new SqlCommand(@"SELECT Ogr.Adi+' '+Ogr.Soyadi as AdiSoyadi, Ogr.*, 
                    Kl.KullaniciAdi as KaydedenKullaniciAdi, Kl1.KullaniciAdi as DegistirenKullaniciAdi 
                    FROM Ogrenciler AS Ogr
                    INNER JOIN Kullanicilar as Kl on Kl.Id=Ogr.Kaydeden
                    LEFT JOIN Kullanicilar as Kl1 on Kl1.Id=Ogr.Degistiren");
            }

            // normalde derlerde komut ve conneciton verilerini new SqlConnection("Sql Komutu",baglanti) olarak kullanırdık ama şimdi ise
            // bunları ayrı ayrı kullandık peki neden böyle bir şey yaptık sedat abiye sor. Buradan itibaren sql ile bağlantı kurup
            // üzerinde yazdığımız komutları uyguluyabiliyoruz.
            sqlDataAdapter.SelectCommand.Connection = new SqlConnection(baglanti.ConnectionString);
            
            
            // eğer bağlantı kapalıysa aç, açıksa direk geç
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            //BURADA HATA ALDIN DÜZELT BURAYI 
            sqlDataAdapter.Fill(dtTable);

            // ********** ÇOK ÖNEMLİ BİLGİLER ***********
            // burada sql tablomuzdan çektiğimiz verileri listView1 tablomuzun içersine aktardık
            // burada item, her satırdaki veri dizisini ifade eder ve subitem olarak kullandıklarımız ise bu satırın sütunlarını ifade eder.
            // sql tablosundaki verilere ulaşabilmek için dtTable.Rows[RawIndex][ColoumnIndex].ToString() ifadesini kullandık
            // listView1 tablosundaki verilere ulaşmak için ise listView1.Items[RawIndex].SubItems[ColoumnIndex].Text olarak kullanırız
            if (dtTable != null && dtTable.Rows.Count > 0)
            {
                listView1.Items.Clear();
                for (int i = 0; i < dtTable.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = dtTable.Rows[i]["Id"].ToString();
                    item.SubItems.Add(dtTable.Rows[i]["AdiSoyadi"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["OgrenciNo"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["DogumTarihi"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["Cinsiyet"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["Sube"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["Adi"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["Soyadi"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["Notlar"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["KaydedenKullaniciAdi"].ToString());
                    item.SubItems.Add(dtTable.Rows[i]["DegistirenKullaniciAdi"].ToString());
                    listView1.Items.Add(item);
                }
                if (AraKutu.Text.Length >= 3)
                {
                    CheckEdici();
                }

                
            }
            else
            {
                // eğer sql verilerimiz boş ise listView1 tablomuzu boş göstersin
                listView1.Items.Clear();
            }

            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }



        /***BURADA KULLANDIĞIM METODDA DOĞRU BİR YAKLAŞIM SERGİLEDİM FAKAT INNER JOIN VS.. İLE ÇOK DAHA KOLAYLAŞIYOR OLAYLAR***/
        //if (string.IsNullOrEmpty(dtTable.Rows[i]["Kaydeden"].ToString()))
        //{
        //    item.SubItems.Add("");
        //}
        //else
        //{
        //    int _idKay = Convert.ToInt32(dtTable.Rows[i]["Kaydeden"].ToString());
        //    sqlCommand.Parameters.AddWithValue("@Idee", _idKay);
        //    item.SubItems.Add(sqlCommand.ExecuteScalar().ToString());
        //}

        //if (string.IsNullOrEmpty(dtTable.Rows[i]["Degistiren"].ToString()))
        //{
        //    item.SubItems.Add("");
        //}
        //else
        //{
        //    int _idDeg = Convert.ToInt32(dtTable.Rows[i]["Degistiren"]);
        //    sqlCommand.Parameters.AddWithValue("@Idee",_idDeg);
        //    item.SubItems.Add(sqlCommand.ExecuteScalar().ToString());
        //}


        private void KaydetButon_Click(object sender, EventArgs e)
        {
            /***
             * Burad önemli bir konuya değinmek isterim 
             * Sedat abi dedi ki eğer bir arayüz ne kadar sade ve kullanışlı olursa içindeki dönen kod kısımları da
             * o kadar karışık olur demişti. Ben o doğrultuda tek bir kaydet butonu ile hem yeni bir öğrenci varsa onu kaydedebiliyor
             * hem de var olan öğrenciyi güncelleyebiliyoruz 
             * ***/

            // burada kayıtId>0 sorgusunun sebebi eğer bir öğrenci zaten tabloda varsa zaten bu öğrenci bu öğrencinin Id numarası sıfırdan 
            // büyük olacağı için update yani güncelle sorgusuna yönlendiriyoruz. Eğer bu öğrenci zaten yoksa Id değeri de varsayılan olarak
            // 0 gözüküyor ve böylelikle biz de listemize insert sql sorgusu ile yeni bir öğrenci eklemiş olabiliyoruz.
            if (AdKutu.Text == "" || SoyadKutu.Text == "" || NumaraKutu.Text == "" || dateTimePicker1.Value.Date == DateTime.Now.Date || CinsiyetComboBox.Text == "" || SubeComboBox.Text == "" || NotTextBox.Text == "")
            {
                MessageBox.Show("Lütfen Öğrencinin Bilgilerini Tam Giriniz");
            }
            else
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                SqlCommand sqlCommand;
                
                if (KayitId > 0)
                {
                    sqlCommand = new SqlCommand(@"UPDATE Ogrenciler SET OgrenciNo=@OgrenciNo, Adi=@Adi, Soyadi=@Soyadi,  
                                            DogumTarihi=@DogumTarihi, Cinsiyet=@Cinsiyet, Sube=@Sube ,Notlar=@Notlar,Degistiren=@Degistiren WHERE Id = @Id", baglanti);
                    sqlCommand.Parameters.AddWithValue("@Id", KayitId);
                    sqlCommand.Parameters.AddWithValue("@Degistiren",Utils.KullaniciId);
                    
                  
                }
                else
                {
                    sqlCommand = new SqlCommand(@"INSERT INTO Ogrenciler (OgrenciNo, Adi, Soyadi, DogumTarihi, Cinsiyet, Sube, Notlar,Kaydeden)
                                            VALUES (@OgrenciNo, @Adi,  @Soyadi,  @DogumTarihi,  @Cinsiyet,  @Sube, @Notlar,@Kaydeden)", baglanti);

                    sqlCommand.Parameters.AddWithValue("@Kaydeden",Utils.KullaniciId);

                }
                sqlCommand.Parameters.AddWithValue("@OgrenciNo", NumaraKutu.Text);
                sqlCommand.Parameters.AddWithValue("@Adi", AdKutu.Text);
                sqlCommand.Parameters.AddWithValue("@Soyadi", SoyadKutu.Text);
                sqlCommand.Parameters.AddWithValue("@DogumTarihi", dateTimePicker1.Value.Date);
                sqlCommand.Parameters.AddWithValue("@Cinsiyet", CinsiyetComboBox.Text);
                sqlCommand.Parameters.AddWithValue("@Sube", SubeComboBox.Text);
                sqlCommand.Parameters.AddWithValue("@Notlar", NotTextBox.Text);

                

                // sql tablomuzde update,insert,delete vs... gibi değişiklikler yaptığımız zaman muhakkak bu yaptığımız değişiklikleri
                // sql tablomuz üzerinde güncelleyebilmek için sqlCommand.ExecuteNonQuery(); metodunu kullanmak zorundayız.
                sqlCommand.ExecuteNonQuery();

                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }

                // her kaydet butonuna bastığımız zaman bütün listView1 üzerindeki tablo verilerini göstersin ve tüm textBoxlardik yazılı olanları temizlesin.
                VerileriGoster("");
                Temizle();
            }

        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            // burada ise tiklenmiş kutucuklardaki verileri siliyoruz
            if (listView1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Checked)
                    {
                        int Id = Convert.ToInt32(listView1.Items[i].SubItems[0].Text);
                        SqlCommand sqlCommand = new SqlCommand("DELETE FROM Ogrenciler WHERE Id=@id", baglanti);
                        sqlCommand.Parameters.AddWithValue("@id", Id);
                        if (baglanti.State == ConnectionState.Closed)
                        {
                            baglanti.Open();
                        }
                        sqlCommand.ExecuteNonQuery();

                        if (baglanti.State == ConnectionState.Open)
                        {
                            baglanti.Close();
                        }
                    }
                }
                VerileriGoster("");
            }
            // burada biraz daha simge ve buton koyarak görüntüyü güzelleştirdik
            else
            {
                MessageBox.Show("Silinecek kayıtları seçmediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // BURADA YİNE BİR ŞEYLER DENEMİŞİM AMA OLMAMIŞ :P

            foreach (ListViewItem secilibilgi in listView1.CheckedItems)
            {
                SqlCommand secili_sil = new SqlCommand("Delete from Ogrenciler where OgrenciNo = @no", baglanti);
                string no = secilibilgi.SubItems[0].Text;
                secili_sil.Parameters.AddWithValue("@no", no);
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                secili_sil.ExecuteNonQuery();
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        /***
         * burada arakutu içindeki yazı her değiştiğinde ve  karater sayısı 3 adeti geçtiği zaman VerileriGoster(); metoduna girecek
         * ve aramaKriteri olarak da arama kutusunun içindeki text i gönderecek eğer karakter sayısı üçten küçük ise boş liste gözüksün
         * ***/
        private void AraKutu_TextChanged(object sender, EventArgs e)
        {
            if (AraKutu.Text.Length >= 3)
            {
                string aramaKriteri = AraKutu.Text;
                VerileriGoster(aramaKriteri);
            }
            else
            {
                VerileriGoster("");
            }
        }

        // burada listView1 tablosundaki elemanlara çift tıklandığı zaman o satırdaki bilgileri bilgi kutucuklarına aktarsın
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // burada FocusedItem özelliğini kullanarak çift tıkladığımız itemın indexini alabiliyoruz
                int index = listView1.FocusedItem.Index;

                KayitId = Convert.ToInt32(listView1.Items[index].SubItems[0].Text);
                AdKutu.Text = listView1.Items[index].SubItems[6].Text;
                SoyadKutu.Text = listView1.Items[index].SubItems[7].Text;
                SubeComboBox.Text = listView1.Items[index].SubItems[5].Text;
                CinsiyetComboBox.Text = listView1.Items[index].SubItems[4].Text;
                dateTimePicker1.Value = Convert.ToDateTime(listView1.Items[index].SubItems[3].Text);
                NumaraKutu.Text = listView1.Items[index].SubItems[2].Text;
                NotTextBox.Text = listView1.Items[index].SubItems[8].Text;
            }
        }

        // bu da kutucukların içindeki yazıların temizlenmesini sağlıyor
        private void Temizle()
        {
            KayitId = 0;
            AdKutu.Clear();
            SoyadKutu.Clear();
            // combobox'lar -1 değeri ile temizleniyormuş
            SubeComboBox.SelectedIndex = -1;
            CinsiyetComboBox.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            NumaraKutu.Clear();
            AraKutu.Clear();
            NotTextBox.Clear();
        }

        // burada tablomuzun içinde herhangi bir item check edilmişse o item satırının not ortalaması alınıyor
        // ve anlık olarak ortalama labelının içine yansıtılıyor
        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (AraKutu.Text.Length >= 3)
            {
                // boş return komutu direk o metodun işlevini sonlandırmamızı sağlar
                return;
            }
            else
            {
                OrtalamaAl(listView1);
            }


        }

        // burada ise check edilen itemlerin ortalaması alınıyor
        private void OrtalamaAl(ListView listView)
        {

            if (listView.Items.Count > 0)
            {
                if (listView.CheckedItems.Count > 0)
                {
                    double toplam = 0;
                    for (int i = 0; i < listView.Items.Count; i++)
                    {
                        if (listView.Items[i].Checked)
                        {
                            if (!listeChecked.Contains(Convert.ToInt32(listView.Items[i].SubItems[0].Text)))
                            {
                                listeChecked.Add(Convert.ToInt32(listView.Items[i].SubItems[0].Text));
                            }
                            if (!string.IsNullOrEmpty(listView.Items[i].SubItems[8].Text))
                            {
                                toplam = toplam + Convert.ToDouble(listView.Items[i].SubItems[8].Text);
                            }
                        }
                        else
                        {
                            if (listeChecked.Contains(Convert.ToInt32(listView.Items[i].SubItems[0].Text)))
                            {
                                listeChecked.Remove(Convert.ToInt32(listView.Items[i].SubItems[0].Text));
                            }
                        }
                    }
                    ortalama = toplam / listView.CheckedItems.Count;
                    ortalama = Math.Round(ortalama, 3);
                    ortText.Text = ortalama.ToString();
                    NotTopText.Text = toplam.ToString();
                }
                else
                {
                    ortText.Text = "0";
                    NotTopText.Text = "0";
                }

            }



        }


        /// <summary>
        /// listview itemlerinin check edilip edilmediğini kontrol ediyor
        /// </summary>
        private void CheckEdici()
        {

            for (int i = 0; i < listeChecked.Count; i++)
            {
                for (int j = 0; j < listView1.Items.Count; j++)
                {
                    if (listeChecked[i].ToString() == listView1.Items[j].SubItems[0].Text)
                    {
                        listView1.Items[j].Checked = true;
                    }
                }
            }
            
            OrtalamaAl(listView1);
            listeChecked.RemoveRange(0, listeChecked.Count);
        }



        /// <summary>
        /// BURADA LİSTVİEW İÇİNDEKİ VERİLERİ İSTEDİMİZ DOSYANIN İÇİNE BİR TEXT DOSYASI OLARAK ATABİLMEMİZE OLANAK SAĞLAYAN
        /// BİR KOD GAYET GÜZEL İŞLİYOR 
        /// </summary>
        private async void VerileriDisaAktar()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() {Filter = "Text Documents|*.txt*", ValidateNames = true })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    // TextWriter için System.IO kütüphanesi kullanıldı
                    using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {     
                        foreach(ColumnHeader header in listView1.Columns)
                        {
                            int _pad = header.Index == 1 || header.Index == 3 ? 23 : 10; 
                            await tw.WriteAsync(header.Text.PadRight(_pad)+"||");
                        }
                        await tw.WriteLineAsync();
                        foreach(ListViewItem item in listView1.Items)
                        {
                            for (int i = 0; i < item.SubItems.Count; i++)
                            {
                                int _pad = i == 1 || i==3 ? 25 : 12; 
                                await tw.WriteAsync((item.SubItems[i].Text).PadRight(_pad)) ;
                            }
                            await tw.WriteLineAsync();
                        }
                        MessageBox.Show("Verileriniz Kaydedildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        // burada system diagonistic process start kütüphane elemanını kullanarak istediğimiz uygulamayı 
                        // sırası geldiğinde başlatır.
                        System.Diagnostics.Process.Start(sfd.FileName);
                    }
                }
            }
        }

        private void btnDisaAktar_Click(object sender, EventArgs e)
        {
            VerileriDisaAktar();
        }
    }
}
