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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
        public void Data(string[] data) // Fatura
        {
            dataGridView1.Rows.Add(data.Count()-1);

            dataGridView1.Rows[0].Cells[0].Value = "Adı";
            dataGridView1.Rows[0].Cells[1].Value = data[0];

            dataGridView1.Rows[1].Cells[0].Value = "Soyadı";
            dataGridView1.Rows[1].Cells[1].Value = data[1];

            dataGridView1.Rows[2].Cells[0].Value = "Cinsiyeti";
            dataGridView1.Rows[2].Cells[1].Value = data[2];

            dataGridView1.Rows[3].Cells[0].Value = "TC No";
            dataGridView1.Rows[3].Cells[1].Value = data[3];

            dataGridView1.Rows[4].Cells[0].Value = "Koltuk No";
            dataGridView1.Rows[4].Cells[1].Value = data[4];

            dataGridView1.Rows[5].Cells[0].Value = "Bilet Tutarı";
            dataGridView1.Rows[5].Cells[1].Value = data[5] + " TL";

            dataGridView1.Rows[6].Cells[0].Value = "Hizmet Bedeli";
            dataGridView1.Rows[6].Cells[1].Value = data[6] + " TL";

            dataGridView1.Rows[7].Cells[0].Value = "Toplam Tutar";
            dataGridView1.Rows[7].Cells[1].Value = data[7] + " TL";
        }
    }
}
