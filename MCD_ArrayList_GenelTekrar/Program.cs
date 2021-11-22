using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MCD_ArrayList_GenelKullanimi

{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList Genel Kullanımı

            //10 elemanlı (string) ArrayList içindeki değerleri Z-A olacak Şekilde sıralayınız.

            ArrayList odevListe = new ArrayList();
            odevListe.Add("berkecan");
            odevListe.Add("ögeday");
            odevListe.Add("ebubekir sıddık");
            odevListe.Add("murtaza");
            odevListe.Add("binali");
            odevListe.Add("yarmagül");
            odevListe.Add("hamdican");
            odevListe.Add("rüknettin");


            //Tüm değerleri A-z çevir
            odevListe.Sort();
            odevListe.Reverse();

            foreach(var item in odevListe)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            #endregion
        }
    }
}
