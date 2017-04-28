using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinemav1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form3 ozet = new Form3();
        Form2 rez = new Form2();
        Gosterim gos = new Gosterim();

        #region FilmÖzetButonEvents
        private void btnOzet1_Click(object sender, EventArgs e)
        {
            ozet.Text = gos.salonFilmIsim[1];
            ozet.VideoUrl("HA_qEsrQvr4");
            ozet.Yonetmen("James Mangold");
            ozet.Oyuncular("Doris Morgado", "Boyd Holbrook", "Patrick Stewart", "Dafne Keen", "Hugh Jackman");
            ozet.Sure("137 Dakika");
            ozet.Tip("Aksiyon");
            ozet.Ozet(gos.logan);
            ozet.ShowDialog();
        }

        private void btnOzet2_Click(object sender, EventArgs e)
        {
            ozet.Text = gos.salonFilmIsim[2];
            ozet.VideoUrl("Fxos0387Bo8");
            ozet.Yonetmen("Gore Verbinski");
            ozet.Oyuncular("Mia Goth", "Jason Isaacs", "Dane Dehaan");
            ozet.Sure("146 Dakika");
            ozet.Tip("Gizem");
            ozet.Ozet(gos.yasamKuru);
            ozet.ShowDialog();
        }

        private void btnOzet3_Click(object sender, EventArgs e)
        {
            ozet.Text = gos.salonFilmIsim[3];
            ozet.VideoUrl("nHMa3wVPT0U");
            ozet.Yonetmen("Peter Chelsom");
            ozet.Oyuncular("Carla Gugino", "Asa Butterfield", "Britt Robertson", "Gary Oldman");
            ozet.Sure("120 Dakika");
            ozet.Tip("Bilim Kurgu");
            ozet.Ozet(gos.buDunyaninDisinda);
            ozet.ShowDialog();
        }

        private void btnOzet4_Click(object sender, EventArgs e)
        {
            ozet.Text = gos.salonFilmIsim[4];
            ozet.VideoUrl("hK9-cgPAp4w");
            ozet.Yonetmen("Murat Kaman");
            ozet.Oyuncular("Emrah Kaman", "Cem Yılmaz", "Şafak Pekdemir", "Pelin Akil", "Zafer Algöz");
            ozet.Sure("104 Dakika");
            ozet.Tip("Komedi");
            ozet.Ozet(gos.deliAsk);
            ozet.ShowDialog();
        }

        private void btnOzet5_Click(object sender, EventArgs e)
        {
            
            ozet.Text = gos.salonFilmIsim[5];
            ozet.VideoUrl("lAxRNwyKRtg");
            ozet.Yonetmen("Bill Condon");
            ozet.Oyuncular("Emma Watson", "Dan Stevens", "Luke Evans");
            ozet.Sure("129 Dakika");
            ozet.Tip("Fantastik");
            ozet.Ozet(gos.guzelCirkin);
            ozet.ShowDialog();
        }

        private void btnOzet6_Click(object sender, EventArgs e)
        {
            ozet.Text = gos.salonFilmIsim[6];
            ozet.VideoUrl("Re6xZPyhuZM");
            ozet.Yonetmen("Yılmaz Erdoğan");
            ozet.Oyuncular("Çağlar Çorumlu", "Büşra Pekin", "Gupse Özay", "Şebnem Bozoklu", "Aylin Kontente");
            ozet.Sure("100 Dakika");
            ozet.Tip("Komedi");
            ozet.Ozet(gos.tatlimTatlim);
            ozet.ShowDialog();
        }

        private void btnOzet7_Click(object sender, EventArgs e)
        {
            ozet.Text = gos.salonFilmIsim[7];
            ozet.VideoUrl("cAJaVpUSBuo");
            ozet.Yonetmen("Jordan Vogt-Roberts");
            ozet.Oyuncular("Tom Hiddleston", "Brie Larson", "Toby Kebbell");
            ozet.Sure("118 Dakika");
            ozet.Tip("Macera");
            ozet.Ozet(gos.kingKong);
            ozet.ShowDialog();
        }

        private void btnOzet8_Click(object sender, EventArgs e)
        {
            ozet.Text = gos.salonFilmIsim[8];
            ozet.VideoUrl("uQhsbHpHY8A");
            ozet.Yonetmen("Ferzan Özpetek");
            ozet.Oyuncular("Halit Ergenç", "Zerrin Tekindor", "Mehmet Günsür", "Tuba Büyüküstün", "Nejat İşler");
            ozet.Sure("114 Dakika");
            ozet.Tip("Dram");
            ozet.Ozet(gos.istanbulKirmizisi);
            ozet.ShowDialog();
        }
        #endregion

        #region BiletAlmaFormGeçiş
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            rez.FilmDetay(gos.salonFilmIsim[1], gos.loganSalonNo, gos.loganSeans);
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            rez.FilmDetay(gos.salonFilmIsim[2], gos.yasamkuruSalonNo, gos.yasamkuruSeans);
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();            
            rez.FilmDetay(gos.salonFilmIsim[3], gos.budunyanindisindaSalonNo, gos.budunyanindisindaSeans);
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            rez.FilmDetay(gos.salonFilmIsim[4], gos.deliaskSalonNo, gos.deliaskSeans);
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            rez.FilmDetay(gos.salonFilmIsim[5], gos.guzelcirkinSalonNo, gos.guzelcirkinSeans);
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();            
            rez.FilmDetay(gos.salonFilmIsim[6], gos.tatlimtatlimSalonNo, gos.tatlimtatlimSeans);
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();            
            rez.FilmDetay(gos.salonFilmIsim[7], gos.kongSalonNo, gos.kingkongSeans);
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();            
            rez.FilmDetay(gos.salonFilmIsim[8], gos.istanbulkirmizisiSalonNo, gos.istanbulkirmizisiSeans);
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }
        #endregion


        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doğan Akdeniz\nHasan Can Büyükaşık\nDemir Berk Sever", "Hazırlayanlar");
        }
    }
}
