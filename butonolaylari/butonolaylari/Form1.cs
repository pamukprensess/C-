using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butonolaylari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkolay_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            MessageBox.Show("Kolay BÖlümü Seçtiniz", "KOLAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnorta_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            MessageBox.Show("Orta Zorluğu Seçtiniz", "ORTA ZORLUK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnzor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            MessageBox.Show("Zor BÖlümü Seçtiniz", "ZOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
