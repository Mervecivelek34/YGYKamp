using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maskeTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer();

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);

            


            Console.ReadLine();
        }




        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }




        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmismi = false;

            string ad = "Engin";
            string soyad = "Demiroğlu";
            int dogumYili = 1998;
            long tcNo = 6266;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }

       public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string DogumYili { get; set; }
            public string TcNo { get; set; }


        }
    }

    internal class PttManager
    {
    }
}
