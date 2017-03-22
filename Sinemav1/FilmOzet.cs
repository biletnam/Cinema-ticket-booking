using System.Windows.Forms;

namespace Sinemav1
{
    public partial class FilmOzet : Form
    {
        public FilmOzet()
        {
            InitializeComponent();
            //webBrowser1.Navigate("http://www.youtube.com/v/HLj0aLPLsys?version=3");
        }
        public void VideoUrl(string gelen)
        {
            webBrowser1.Navigate("http://www.youtube.com/v/"+gelen+"?version=3");
        }
        public void Ozet(string gelen)
        {
            richTextBox1.Text = gelen;
        }
        public void Yonetmen(string gelen)
        {
            label5.Text = gelen;
        }
        public void Oyuncular(params string[] gelen)
        {
            label6.Text = "";
            for (int i = 0; i < gelen.Length; i++)
            {
                label6.Text += gelen[i];
                if (i != (gelen.Length - 1))
                    label6.Text += ", ";
            }
        }
        public void Sure(string gelen)
        {
            label7.Text = gelen;
        }
        public void Tip(string gelen)
        {
            label8.Text = gelen;
        }
        
    }
}
