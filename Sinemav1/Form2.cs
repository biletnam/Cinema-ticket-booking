using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sinemav1
{
    public partial class Form2 : Form
    {
        Koltuk kol = new Koltuk();
        Bilet bil = new Bilet();
        İndirimliBilet ibil = new İndirimliBilet();
        ErrorProvider provider = new ErrorProvider();
        
        public Form2()
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
                    label17.Text = (Convert.ToDouble(label17.Text.Substring(0,label17.Text.Length-3)) + bil.FiyatTam).ToString()+" TL";
                    break;
                case "DeepSkyBlue":
                    sesbiriki.BackColor = Color.LightGreen;
                    listBox1.Items.Remove(sesbiriki.Name.Substring(2, 1) + sesbiriki.Name.Substring(3));
                    label17.Text = (Convert.ToDouble(label17.Text.Substring(0, label17.Text.Length - 3)) - bil.FiyatTam).ToString() +" TL";
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
        public void GirdiTemizle()
        {
            textBox2.Text = textBox5.Text = textBox6.Text = textBox7.Text= "";
            comboBox1.SelectedIndex = -1;
        }
        public void ParaTemizle()
        {
            label17.Text = "0 TL";
        }
        #endregion

        #region ControlEventleri
        private void button1_Click(object sender, EventArgs e)
        {
            bool durumTB5 = ValidateTB5();
            bool durumTB6 = ValidateTB6();
            bool durumTB7 = ValidateTB7();
            bool durumCB1 = ValidateCB1();
            bool durumTB2 = ValidateTB2();
            bool durumLB1 = ValidateLB1();
            if (durumTB5 && durumTB6 && durumTB7 && durumCB1 && durumTB2 && durumLB1)
            {
                bil.Ad = textBox5.Text;
                bil.Soyad = textBox6.Text;
                bil.TcNo = textBox7.Text;
                bil.Cinsiyet = comboBox1.SelectedItem.ToString();
                kol.Rezervasyon(textBox1.Text, comboBox3.SelectedIndex, listBox1);
                DoluMu(textBox1.Text, comboBox3.SelectedIndex);
                bil.BilgiYazdir(textBox2.Text, listBox1);
                GirdiTemizle();
                ParaTemizle();
            }
            else
            {                               
                if (!durumTB2)
                    MessageBox.Show("İndirim Kodu Hatalı!");
                else if(!durumLB1)
                    MessageBox.Show("Koltuk Seçimi Yapılmadı!");
                else
                    MessageBox.Show("Lütfen zorunlu(*) alanları doldurunuz!");
            }
        }
        private void textBoxAlpha_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                        && !char.IsSeparator(e.KeyChar);
        }
        private void textBoxNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateTB2();
        }
        public bool ValidateTB2()
        {           
            bool durum = true;
            int i = 0;
            foreach (string kod in ibil.IndirimKod)
            {
                if (textBox2.Text == "")
                    i++;
                else if (textBox2.Text == kod)
                    i++;
            }
            if (i == 0)
                durum = false;
            return durum;
        }
        private void listBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateLB1();
        }
        public bool ValidateLB1()
        {
            bool durum = true;
            if (listBox1.Items.Count == 0)
                durum = false;
            return durum;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                button2.Enabled = true;
            else
                button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == ibil.IndirimKod[0])
                MessageBox.Show("%5 indirim kazandınız.\nİşlem sonunda bilet tutarından düşelecektir.");
            else if (textBox2.Text == ibil.IndirimKod[1])
                MessageBox.Show("%15 indirim kazandınız.\nİşlem sonunda bilet tutarından düşelecektir.");
            else if (textBox2.Text == ibil.IndirimKod[2])
                MessageBox.Show("%20 indirim kazandınız.\nİşlem sonunda bilet tutarından düşelecektir.");
            else
            {
                MessageBox.Show("Geçersiz indirim kodu.");
                textBox2.Text = "";
                textBox2.Select();
            }
        }
        #endregion


    }
}
