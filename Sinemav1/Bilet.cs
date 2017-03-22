using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinemav1
{
    class Bilet
    {
        private string ad, soyad, tcNo, cinsiyet;
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
        public void BilgiYazdir(ListBox x)
        {
            string koltukNo =" ";
            for (int i = 0; i < x.Items.Count; i++)
            {
                koltukNo += x.Items[i];
                if (x.Items.Count - 1 != i)
                    koltukNo += ", ";
            }
            MessageBox.Show("Ad : "+ad+"\n"+"Soyad :"+soyad + "\n" + "Cinsiyet : "+cinsiyet + "\n" +"TC No : "+ tcNo + "\n" + "Koltuk No : " + koltukNo ,"Rezervasyon Gerçekleştirildi!",MessageBoxButtons.OK);
            x.Items.Clear();
        }
    }
}
