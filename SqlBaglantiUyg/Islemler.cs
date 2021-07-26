using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBaglantiUyg
{
    public  class Islemler
    {
         SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7SDHT04;Initial Catalog=OGRENCIYONETIMSISTEMI;Integrated Security=True");


        public DataTable Kullanicilar()
        {
            baglanti.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand("SELECT * FROM Kullanicilar WHERE Aktif=1 ORDER BY KullaniciAdi ASC");
            sqlDataAdapter.SelectCommand.Connection = new SqlConnection(baglanti.ConnectionString);
            DataTable dtAktifler = new DataTable();
            sqlDataAdapter.Fill(dtAktifler);
            baglanti.Close();
            return dtAktifler;
        }

       


       











    }
}
