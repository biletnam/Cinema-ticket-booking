using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sinemav1
{
    public partial class FormKoltuk : Form
    {
        Koltuk kol = new Koltuk();
        ErrorProvider provider = new ErrorProvider();
        public FormKoltuk()
        {
            InitializeComponent();            
        }
        #region Methodlarım
        public void FilmDetay(string gelen, int salon, params string[] seansSaatleri)
        {
            comboBox3.Items.Clear();
            textBox1.Text = gelen;
            comboBox2.SelectedIndex = salon - 1;
            for (int i = 0; i < seansSaatleri.Length; i++)
                comboBox3.Items.Add(seansSaatleri[i]);
        }
        public void DoluMu(string filmIsmi, int seansIndex)
        {
            List<Control> a = new List<Control>();
            foreach (Control c in Controls.OfType<CheckBox>())
            {
                a.Add(c);
            }
            kol.DoluMu(seansIndex, textBox1, a);
        }
        private bool ValidateTB5()
        {
            bool durum = true;
            if (textBox5.Text == "")
            {
                provider.SetError(textBox5, "Lütfen adınızı giriniz");
                durum = false;
            }
            else
                provider.SetError(textBox5, "");
            return durum;
        }
        private bool ValidateTB6()
        {
            bool durum = true;
            if (textBox6.Text == "")
            {
                provider.SetError(textBox6, "Lütfen soyadınızı giriniz");
                durum = false;
            }
            else
                provider.SetError(textBox6, "");
            return durum;
        }
        private bool ValidateTB7()
        {
            bool durum = true;
            if (textBox7.Text == "")
            {
                provider.SetError(textBox7, "Lütfen TC kimlik numaranızı giriniz");
                durum = false;
            }
            else
                provider.SetError(textBox7, "");
            return durum;
        }
        private bool ValidateCB1()
        {
            bool durum = true;
            if (comboBox1.SelectedIndex == -1)
            {
                provider.SetError(comboBox1, "Lütfen cinsiyet seçin");
                durum = false;
            }
            else
                provider.SetError(comboBox1, "");
            return durum;
        }
        public void cbPasif()
        {
            foreach (Control c in Controls.OfType<CheckBox>())
            {
                ((CheckBox)c).Enabled = false;
            }
        }
        public void cbTemizle()
        {
            foreach (Control c in Controls.OfType<CheckBox>())
            {
                ((CheckBox)c).Checked = false;
                ((CheckBox)c).Enabled = true;
                ((CheckBox)c).BackColor = Color.LightGreen;
            }
        }
        public void cbEvent(object sender, EventArgs e)
        {
            Control sesbiriki = ((Control)sender);
            switch (sesbiriki.BackColor.Name)
            {
                case "LightGreen":
                    sesbiriki.BackColor = Color.DeepSkyBlue;
                    listBox1.Items.Add(sesbiriki.Name.Substring(2, 1) + sesbiriki.Name.Substring(3));
                    break;
                case "DeepSkyBlue":
                    sesbiriki.BackColor = Color.LightGreen;
                    listBox1.Items.Remove(sesbiriki.Name.Substring(2, 1) + sesbiriki.Name.Substring(3));
                    break;
                default:
                    sesbiriki.BackColor = SystemColors.Control;
                    break;
            }
        }
        public void lbTemizle()
        {
            listBox1.Items.Clear();
        }
        #endregion

        #region ControlEventleri
        private void button1_Click(object sender, EventArgs e)
        {
            Bilet bil = new Bilet();
            bool durumTB5 = ValidateTB5();
            bool durumTB6 = ValidateTB6();
            bool durumTB7 = ValidateTB7();
            bool durumCB1 = ValidateCB1();
            if (durumTB5 && durumTB6 && durumTB7 && durumCB1)
            {
                bil.Ad = textBox5.Text;
                bil.Soyad = textBox6.Text;
                bil.TcNo = textBox7.Text;
                bil.Cinsiyet = comboBox1.SelectedItem.ToString();
                kol.Rezervasyon(textBox1.Text, comboBox3.SelectedIndex, listBox1);
                DoluMu(textBox1.Text, comboBox3.SelectedIndex);
                bil.BilgiYazdir(listBox1);
            }
            else
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listBox1_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            button4.Enabled = false;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTemizle();
            lbTemizle();
            DoluMu(textBox1.Text, comboBox3.SelectedIndex);
        }

        private void FormKoltuk_FormClosing(object sender, FormClosingEventArgs e)
        {
            cbPasif();
        }

        private void FormKoltuk_Load(object sender, EventArgs e)
        {
            cbPasif();
        }
        private void textBox5_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTB5();
        }
        private void textBox6_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTB6();
        }
        private void textBox7_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTB7();
        }
        private void comboBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateCB1();
        }
        #endregion       
    }
}
