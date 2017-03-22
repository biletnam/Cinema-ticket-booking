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
        #region FilmÖzetButonEvents
        FilmOzet deneme = new FilmOzet();
        private void btnOzet1_Click(object sender, EventArgs e)
        {
            deneme.Text = "Logan";
            deneme.VideoUrl("HA_qEsrQvr4");
            deneme.Yonetmen("James Mangold");
            deneme.Oyuncular("Doris Morgado", "Boyd Holbrook", "Patrick Stewart", "Dafne Keen", "Hugh Jackman");
            deneme.Sure("137 Dakika");
            deneme.Tip("Aksiyon");
            deneme.Ozet(Gosterim.logan);
            deneme.ShowDialog();
        }

        private void btnOzet2_Click(object sender, EventArgs e)
        {
            deneme.Text = "Yaşam Kürü";
            deneme.VideoUrl("Fxos0387Bo8");
            deneme.Yonetmen("Gore Verbinski");
            deneme.Oyuncular("Mia Goth", "Jason Isaacs", "Dane Dehaan");
            deneme.Sure("146 Dakika");
            deneme.Tip("Gizem");
            deneme.Ozet(Gosterim.yasamKuru);
            deneme.ShowDialog();
        }

        private void btnOzet3_Click(object sender, EventArgs e)
        {
            deneme.Text = "Bu Dünyanın Dışında";
            deneme.VideoUrl("nHMa3wVPT0U");
            deneme.Yonetmen("Peter Chelsom");
            deneme.Oyuncular("Carla Gugino", "Asa Butterfield", "Britt Robertson", "Gary Oldman");
            deneme.Sure("120 Dakika");
            deneme.Tip("Bilim Kurgu");
            deneme.Ozet(Gosterim.buDunyaninDisinda);
            deneme.ShowDialog();
        }

        private void btnOzet4_Click(object sender, EventArgs e)
        {
            deneme.Text = "Deli Aşk";
            deneme.VideoUrl("hK9-cgPAp4w");
            deneme.Yonetmen("Murat Kaman");
            deneme.Oyuncular("Emrah Kaman", "Cem Yılmaz", "Şafak Pekdemir", "Pelin Akil", "Zafer Algöz");
            deneme.Sure("104 Dakika");
            deneme.Tip("Komedi");
            deneme.Ozet(Gosterim.deliAsk);
            deneme.ShowDialog();
        }

        private void btnOzet5_Click(object sender, EventArgs e)
        {
            
            deneme.Text = "Güzel ve Çirkin";
            deneme.VideoUrl("lAxRNwyKRtg");
            deneme.Yonetmen("Bill Condon");
            deneme.Oyuncular("Emma Watson", "Dan Stevens", "Luke Evans");
            deneme.Sure("129 Dakika");
            deneme.Tip("Fantastik");
            deneme.Ozet(Gosterim.guzelCirkin);
            deneme.ShowDialog();
        }

        private void btnOzet6_Click(object sender, EventArgs e)
        {
            deneme.Text = "Tatlım Tatlım";
            deneme.VideoUrl("Re6xZPyhuZM");
            deneme.Yonetmen("Yılmaz Erdoğan");
            deneme.Oyuncular("Çağlar Çorumlu", "Büşra Pekin", "Gupse Özay", "Şebnem Bozoklu", "Aylin Kontente");
            deneme.Sure("100 Dakika");
            deneme.Tip("Komedi");
            deneme.Ozet(Gosterim.tatlimTatlim);
            deneme.ShowDialog();
        }

        private void btnOzet7_Click(object sender, EventArgs e)
        {
            deneme.Text = "Kong";
            deneme.VideoUrl("cAJaVpUSBuo");
            deneme.Yonetmen("Jordan Vogt-Roberts");
            deneme.Oyuncular("Tom Hiddleston", "Brie Larson", "Toby Kebbell");
            deneme.Sure("118 Dakika");
            deneme.Tip("Macera");
            deneme.Ozet(Gosterim.kingKong);
            deneme.ShowDialog();
        }

        private void btnOzet8_Click(object sender, EventArgs e)
        {
            deneme.Text = "İstanbul Kırmızısı";
            deneme.VideoUrl("uQhsbHpHY8A");
            deneme.Yonetmen("Ferzan Özpetek");
            deneme.Oyuncular("Halit Ergenç", "Zerrin Tekindor", "Mehmet Günsür", "Tuba Büyüküstün", "Nejat İşler");
            deneme.Sure("114 Dakika");
            deneme.Tip("Dram");
            deneme.Ozet(Gosterim.istanbulKirmizisi);
            deneme.ShowDialog();
        }
        #endregion


        FormKoltuk rez = new FormKoltuk();
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            rez.FilmDetay("Logan", 1, "09:45", "12:20", "15:15", "18:10", "21:10");
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            rez.FilmDetay("Yaşam Kürü", 2, "11:00", "14:30", "16:30", "18:00", "21:30");
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();            
            rez.FilmDetay("Bu Dünyanın Dışında", 3, "11:10", "13:50", "16:25", "19:00", "21:35");
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            rez.FilmDetay("Deli Aşk", 4, "10:15", "12:15", "14:40", "17:00", "19:20", "21:40");
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            rez.FilmDetay("Güzel ve Çirkin", 5, "11:00", "13:45", "16:30", "19:15", "22:00");
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();            
            rez.FilmDetay("Tatlım Tatlım", 6, "10:30", "12:45", "15:00", "17:20", "19:40", "22:00");
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();            
            rez.FilmDetay("Kong", 7, "11:00", "13:40", "16:20", "19:00", "21:50");
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();            
            rez.FilmDetay("İstanbul Kırmızısı", 8, "10:50", "13:25", "16:10", "18:50", "21:30");
            rez.ShowDialog();
            rez.cbTemizle();
            this.Show();
        }
    }
}
