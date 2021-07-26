using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SqlBaglantiUyg
{
    public static class Utils
    {

        public static string KullaniciAdi;
        public static int KullaniciId;
        public static string SifreDegisimKullanici;
        public static string KullaniciDegisimAdi;
        public static int KullaniciDegisimId;
        public static int StokItemId;


        /***BURADA STATIC METODLARDA DEĞER DÖNDÜRMENİN FARKLI BİR YOLUNU GÖRÜYORUZ***/
        // BURADAKİ VALUE DEĞİŞKENİNİ STATİK METODU NEREDE KULLANIYORSAK ORADA ATADIĞIMIZ DEĞERİ DÖNDÜRÜYOR
        /***
         * Class FrmLogin{
         * int a = 5;
         * Utils.KullaniciAdiAl = a;
         * ---> burada a=5 değeri yani static method içersindeki value değerine karşılık geliyor
         * ---> sonrada bunu ayrıca yukarıda tanımladığımız _kullaniciText değişkenine atayıp static metodumuzda return edebiliyoruz
         * } 
         ***/

        //private static string _kullaniciText;
        //private static string _sifreText;
        //static public string KullaniciAdiAl
        //{
        //    get
        //    {
        //        return _kullaniciText;
        //    }
        //    set
        //    {
        //        _kullaniciText = value;
        //    }

        //}

        //static public string SifreAl
        //{
        //    get
        //    {
        //        return _sifreText;
        //    }
        //    set
        //    {
        //        _sifreText = value;
        //    }
        //}

    }
}
