using System.Windows.Forms;

namespace Sinemav1
{
    class Bilet
    {
        private string ad, soyad, tcNo, cinsiyet;
        private static double fiyatTam = 17.00;
        private static double hizmetBedeli = 1.75;
        public static int say;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string TcNo
        {
            get { return tcNo; }
            set { tcNo = value; }
        }
        public string Cinsiyet
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }        
        public double FiyatTam
        {
            get
            {
                return fiyatTam;
            }
            private set
            {

            }
        }
        public double HizmetBedeli
        {
            get
            {
                return hizmetBedeli;
            }
            private set
            {

            }
        }
        public void BilgiYazdir(string kod,ListBox x)
        {
            say = x.Items.Count;
            İndirimliBilet ib = new İndirimliBilet();
            
            string koltukNo = "";
            for (int i = 0; i < x.Items.Count; i++)
            {
                koltukNo += x.Items[i];
                if (x.Items.Count - 1 != i)
                    koltukNo += ", ";
            }
            string[] veri = { ad, soyad, cinsiyet, tcNo, koltukNo, ib.İndirimMiktari(kod).ToString("F2") , hizmetBedeli.ToString(), (ib.İndirimMiktari(kod) +hizmetBedeli).ToString("F2") };
            Form4 fm4 = new Form4();
            fm4.Data(veri);
            fm4.ShowDialog();
            x.Items.Clear();
        }
    }
}
