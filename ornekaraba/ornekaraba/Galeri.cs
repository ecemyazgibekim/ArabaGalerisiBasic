using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornekaraba
{
    public class Galeri
    {
        private List<Araba> Arabalar = new List<Araba>(); //composition

        public void ArabaEkle(Araba a)
        {
            Arabalar.Add(a);
        }
        public void ArabaSat(Araba a)
        {
            Arabalar.Remove(a);
        }
        public string ArabalariListele()
        {
            string bilgi = "";
            foreach (Araba araba in Arabalar) //Araba sınıfından ürettiğimiz araba nesnemizi Arabalar listesinde döndür
            {  //her döngüde nesne yaratıyor
                bilgi += "Marka:" + araba.Marka + "\nModel:" + araba.Model +
                    "\nRenk:" + araba.Renk;
            }
            return bilgi;
        }
        public List<Araba> ArabaListesiniVer()
        {
            return Arabalar;
        }
    }
}
