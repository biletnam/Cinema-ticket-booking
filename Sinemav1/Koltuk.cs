using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sinemav1
{
    class Koltuk
    {
        #region KoltukNumaraları
        // Logan Koltuk
        public ArrayList LoganSeans1 = new ArrayList();
        public ArrayList LoganSeans2 = new ArrayList();
        public ArrayList LoganSeans3 = new ArrayList();
        public ArrayList LoganSeans4 = new ArrayList();
        public ArrayList LoganSeans5 = new ArrayList();
        // Yaşam Kürü Koltuk
        public ArrayList YasamKuruSeans1 = new ArrayList();
        public ArrayList YasamKuruSeans2 = new ArrayList();
        public ArrayList YasamKuruSeans3 = new ArrayList();
        public ArrayList YasamKuruSeans4 = new ArrayList();
        public ArrayList YasamKuruSeans5 = new ArrayList();
        // Bu Dünyanın Dışında
        public ArrayList BuDunyaninDisindaSeans1 = new ArrayList();
        public ArrayList BuDunyaninDisindaSeans2 = new ArrayList();
        public ArrayList BuDunyaninDisindaSeans3 = new ArrayList();
        public ArrayList BuDunyaninDisindaSeans4 = new ArrayList();
        public ArrayList BuDunyaninDisindaSeans5 = new ArrayList();
        // Deli Aşk
        public ArrayList DeliAskSeans1 = new ArrayList();
        public ArrayList DeliAskSeans2 = new ArrayList();
        public ArrayList DeliAskSeans3 = new ArrayList();
        public ArrayList DeliAskSeans4 = new ArrayList();
        public ArrayList DeliAskSeans5 = new ArrayList();
        public ArrayList DeliAskSeans6 = new ArrayList();
        // Güzel ve Çirkin
        public ArrayList GuzelCirkinSeans1 = new ArrayList();
        public ArrayList GuzelCirkinSeans2 = new ArrayList();
        public ArrayList GuzelCirkinSeans3 = new ArrayList();
        public ArrayList GuzelCirkinSeans4 = new ArrayList();
        public ArrayList GuzelCirkinSeans5 = new ArrayList();
        // Tatlım Tatlım
        public ArrayList TatlimTatlimSeans1 = new ArrayList();
        public ArrayList TatlimTatlimSeans2 = new ArrayList();
        public ArrayList TatlimTatlimSeans3 = new ArrayList();
        public ArrayList TatlimTatlimSeans4 = new ArrayList();
        public ArrayList TatlimTatlimSeans5 = new ArrayList();
        public ArrayList TatlimTatlimSeans6 = new ArrayList();
        // Kong
        public ArrayList KongSeans1 = new ArrayList();
        public ArrayList KongSeans2 = new ArrayList();
        public ArrayList KongSeans3 = new ArrayList();
        public ArrayList KongSeans4 = new ArrayList();
        public ArrayList KongSeans5 = new ArrayList();
        // İstanbul Kırmızısı
        public ArrayList İstanbulKirmizisiSeans1 = new ArrayList();
        public ArrayList İstanbulKirmizisiSeans2 = new ArrayList();
        public ArrayList İstanbulKirmizisiSeans3 = new ArrayList();
        public ArrayList İstanbulKirmizisiSeans4 = new ArrayList();
        public ArrayList İstanbulKirmizisiSeans5 = new ArrayList();
        #endregion
        public void Rezervasyon(string filmIsmi, int seansIndex , ListBox x)
        {
            if (filmIsmi == "Logan")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < x.Items.Count; i++) LoganSeans1.Add(x.Items[i]);
                        break;
                    case 1:
                        for (int i = 0; i < x.Items.Count; i++) LoganSeans2.Add(x.Items[i]);
                        break;
                    case 2:
                        for (int i = 0; i < x.Items.Count; i++) LoganSeans3.Add(x.Items[i]);
                        break;
                    case 3:
                        for (int i = 0; i < x.Items.Count; i++) LoganSeans4.Add(x.Items[i]);
                        break;
                    case 4:
                        for (int i = 0; i < x.Items.Count; i++) LoganSeans5.Add(x.Items[i]);
                        break;
                }
            }
            else if (filmIsmi == "Yaşam Kürü")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < x.Items.Count; i++) YasamKuruSeans1.Add(x.Items[i]);
                        break;
                    case 1:
                        for (int i = 0; i < x.Items.Count; i++) YasamKuruSeans1.Add(x.Items[i]);
                        break;
                    case 2:
                        for (int i = 0; i < x.Items.Count; i++) YasamKuruSeans1.Add(x.Items[i]);
                        break;
                    case 3:
                        for (int i = 0; i < x.Items.Count; i++) YasamKuruSeans1.Add(x.Items[i]);
                        break;
                    case 4:
                        for (int i = 0; i < x.Items.Count; i++) YasamKuruSeans1.Add(x.Items[i]);
                        break;
                }
            }
            else if(filmIsmi == "Bu Dünyanın Dışında")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < x.Items.Count; i++) BuDunyaninDisindaSeans1.Add(x.Items[i]);
                        break;
                    case 1:
                        for (int i = 0; i < x.Items.Count; i++) BuDunyaninDisindaSeans2.Add(x.Items[i]);
                        break;
                    case 2:
                        for (int i = 0; i < x.Items.Count; i++) BuDunyaninDisindaSeans3.Add(x.Items[i]);
                        break;
                    case 3:
                        for (int i = 0; i < x.Items.Count; i++) BuDunyaninDisindaSeans4.Add(x.Items[i]);
                        break;
                    case 4:
                        for (int i = 0; i < x.Items.Count; i++) BuDunyaninDisindaSeans5.Add(x.Items[i]);
                        break;                    
                }
            }
            else if(filmIsmi == "Deli Aşk")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < x.Items.Count; i++) DeliAskSeans1.Add(x.Items[i]);
                        break;
                    case 1:
                        for (int i = 0; i < x.Items.Count; i++) DeliAskSeans2.Add(x.Items[i]);
                        break;
                    case 2:
                        for (int i = 0; i < x.Items.Count; i++) DeliAskSeans3.Add(x.Items[i]);
                        break;
                    case 3:
                        for (int i = 0; i < x.Items.Count; i++) DeliAskSeans4.Add(x.Items[i]);
                        break;
                    case 4:
                        for (int i = 0; i < x.Items.Count; i++) DeliAskSeans5.Add(x.Items[i]);
                        break;
                    case 5:
                        for (int i = 0; i < x.Items.Count; i++) DeliAskSeans6.Add(x.Items[i]);
                        break;
                }
            }
            else if (filmIsmi == "Güzel ve Çirkin")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < x.Items.Count; i++) GuzelCirkinSeans1.Add(x.Items[i]);
                        break;
                    case 1:
                        for (int i = 0; i < x.Items.Count; i++) GuzelCirkinSeans2.Add(x.Items[i]);
                        break;
                    case 2:
                        for (int i = 0; i < x.Items.Count; i++) GuzelCirkinSeans3.Add(x.Items[i]);
                        break;
                    case 3:
                        for (int i = 0; i < x.Items.Count; i++) GuzelCirkinSeans4.Add(x.Items[i]);
                        break;
                    case 4:
                        for (int i = 0; i < x.Items.Count; i++) GuzelCirkinSeans5.Add(x.Items[i]);
                        break;
                }
            }
            else if (filmIsmi == "Tatlım Tatlım")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < x.Items.Count; i++) TatlimTatlimSeans1.Add(x.Items[i]);
                        break;
                    case 1:
                        for (int i = 0; i < x.Items.Count; i++) TatlimTatlimSeans2.Add(x.Items[i]);
                        break;
                    case 2:
                        for (int i = 0; i < x.Items.Count; i++) TatlimTatlimSeans3.Add(x.Items[i]);
                        break;
                    case 3:
                        for (int i = 0; i < x.Items.Count; i++) TatlimTatlimSeans4.Add(x.Items[i]);
                        break;
                    case 4:
                        for (int i = 0; i < x.Items.Count; i++) TatlimTatlimSeans5.Add(x.Items[i]);
                        break;
                    case 5:
                        for (int i = 0; i < x.Items.Count; i++) TatlimTatlimSeans6.Add(x.Items[i]);
                        break;
                }
            }
            else if (filmIsmi == "Kong")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < x.Items.Count; i++) KongSeans1.Add(x.Items[i]);
                        break;
                    case 1:
                        for (int i = 0; i < x.Items.Count; i++) KongSeans2.Add(x.Items[i]);
                        break;
                    case 2:
                        for (int i = 0; i < x.Items.Count; i++) KongSeans3.Add(x.Items[i]);
                        break;
                    case 3:
                        for (int i = 0; i < x.Items.Count; i++) KongSeans4.Add(x.Items[i]);
                        break;
                    case 4:
                        for (int i = 0; i < x.Items.Count; i++) KongSeans5.Add(x.Items[i]);
                        break;
                }
            }
            else if (filmIsmi == "İstanbul Kırmızısı")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < x.Items.Count; i++) İstanbulKirmizisiSeans1.Add(x.Items[i]);
                        break;
                    case 1:
                        for (int i = 0; i < x.Items.Count; i++) İstanbulKirmizisiSeans2.Add(x.Items[i]);
                        break;
                    case 2:
                        for (int i = 0; i < x.Items.Count; i++) İstanbulKirmizisiSeans3.Add(x.Items[i]);
                        break;
                    case 3:
                        for (int i = 0; i < x.Items.Count; i++) İstanbulKirmizisiSeans4.Add(x.Items[i]);
                        break;
                    case 4:
                        for (int i = 0; i < x.Items.Count; i++) İstanbulKirmizisiSeans5.Add(x.Items[i]);
                        break;
                }
            }
        }
        public void DoluMu(int seansIndex, TextBox textBox1, List<Control> checks)
        {
            if (textBox1.Text == "Logan")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < this.LoganSeans1.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.LoganSeans1[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 1:
                        for (int i = 0; i < this.LoganSeans2.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.LoganSeans2[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 2:
                        for (int i = 0; i < this.LoganSeans3.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.LoganSeans3[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 3:
                        for (int i = 0; i < this.LoganSeans4.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.LoganSeans4[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 4:
                        for (int i = 0; i < this.LoganSeans5.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.LoganSeans5[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                }
            }
            else if (textBox1.Text == "Yaşam Kürü")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < this.YasamKuruSeans1.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.YasamKuruSeans1[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 1:
                        for (int i = 0; i < this.YasamKuruSeans2.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.YasamKuruSeans2[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 2:
                        for (int i = 0; i < this.YasamKuruSeans3.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.YasamKuruSeans3[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 3:
                        for (int i = 0; i < this.YasamKuruSeans4.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.YasamKuruSeans4[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 4:
                        for (int i = 0; i < this.YasamKuruSeans5.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.YasamKuruSeans5[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                }
            }
            else if (textBox1.Text == "Bu Dünyanın Dışında")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < this.BuDunyaninDisindaSeans1.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.BuDunyaninDisindaSeans1[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 1:
                        for (int i = 0; i < this.BuDunyaninDisindaSeans2.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.BuDunyaninDisindaSeans2[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 2:
                        for (int i = 0; i < this.BuDunyaninDisindaSeans3.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.BuDunyaninDisindaSeans3[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 3:
                        for (int i = 0; i < this.BuDunyaninDisindaSeans4.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.BuDunyaninDisindaSeans4[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 4:
                        for (int i = 0; i < this.BuDunyaninDisindaSeans5.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.BuDunyaninDisindaSeans5[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                }
            }
            else if (textBox1.Text == "Deli Aşk")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < this.DeliAskSeans1.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.DeliAskSeans1[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 1:
                        for (int i = 0; i < this.DeliAskSeans2.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.DeliAskSeans2[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 2:
                        for (int i = 0; i < this.DeliAskSeans3.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.DeliAskSeans3[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 3:
                        for (int i = 0; i < this.DeliAskSeans4.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.DeliAskSeans4[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 4:
                        for (int i = 0; i < this.DeliAskSeans5.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.DeliAskSeans5[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 5:
                        for (int i = 0; i < this.DeliAskSeans6.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.DeliAskSeans6[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                }
            }
            else if (textBox1.Text == "Güzel ve Çirkin")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < this.GuzelCirkinSeans1.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.GuzelCirkinSeans1[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 1:
                        for (int i = 0; i < this.GuzelCirkinSeans2.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.GuzelCirkinSeans2[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 2:
                        for (int i = 0; i < this.GuzelCirkinSeans3.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.GuzelCirkinSeans3[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 3:
                        for (int i = 0; i < this.GuzelCirkinSeans4.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.GuzelCirkinSeans4[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 4:
                        for (int i = 0; i < this.GuzelCirkinSeans5.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.GuzelCirkinSeans5[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                }
            }
            else if (textBox1.Text == "Tatlım Tatlım")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < this.TatlimTatlimSeans1.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.TatlimTatlimSeans1[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 1:
                        for (int i = 0; i < this.TatlimTatlimSeans2.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.TatlimTatlimSeans2[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 2:
                        for (int i = 0; i < this.TatlimTatlimSeans3.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.TatlimTatlimSeans3[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 3:
                        for (int i = 0; i < this.TatlimTatlimSeans4.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.TatlimTatlimSeans4[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 4:
                        for (int i = 0; i < this.TatlimTatlimSeans5.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.TatlimTatlimSeans5[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 5:
                        for (int i = 0; i < this.TatlimTatlimSeans6.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.TatlimTatlimSeans6[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                }
            }
            else if (textBox1.Text == "Kong")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < this.KongSeans1.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.KongSeans1[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 1:
                        for (int i = 0; i < this.KongSeans2.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.KongSeans2[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 2:
                        for (int i = 0; i < this.KongSeans3.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.KongSeans3[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 3:
                        for (int i = 0; i < this.KongSeans4.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.KongSeans4[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 4:
                        for (int i = 0; i < this.KongSeans5.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.KongSeans5[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                }
            }
            else if (textBox1.Text == "İstanbul Kırmızısı")
            {
                switch (seansIndex)
                {
                    case 0:
                        for (int i = 0; i < this.İstanbulKirmizisiSeans1.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.İstanbulKirmizisiSeans1[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 1:
                        for (int i = 0; i < this.İstanbulKirmizisiSeans2.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.İstanbulKirmizisiSeans2[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 2:
                        for (int i = 0; i < this.İstanbulKirmizisiSeans3.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.İstanbulKirmizisiSeans3[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 3:
                        for (int i = 0; i < this.İstanbulKirmizisiSeans4.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.İstanbulKirmizisiSeans4[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                    case 4:
                        for (int i = 0; i < this.İstanbulKirmizisiSeans5.Count; i++)
                            foreach (Control c in checks)
                                if (((CheckBox)c).Name.ToString().Substring(2) == this.İstanbulKirmizisiSeans5[i].ToString())
                                {
                                    ((CheckBox)c).BackColor = Color.Red;
                                    ((CheckBox)c).Enabled = false;
                                }
                        break;
                }
            }
        }
    }
}
