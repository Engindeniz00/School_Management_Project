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
        public DataTable Kullanicilar()
        {
            string sorgu = "SELECT * FROM Kullanicilar WHERE Aktif=1 ORDER BY KullaniciAdi ASC";
            DataTable dtKullanici = new DataTable();
            dtKullanici = Utils.TabloGetir(sorgu);
            return dtKullanici;
        }

       


       











    }
}
