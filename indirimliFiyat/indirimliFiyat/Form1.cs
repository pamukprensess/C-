using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indirimliFiyat
{
    public partial class Form1 : Form
    {
        double etiketFiyati;
        double indirimliFiyat;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            etiketFiyati = Convert.ToDouble(textBox1.Text);
            indirimliFiyat = etiketFiyati - etiketFiyati * 0.10;
            label3.Text = indirimliFiyat.ToString();
        }
    }
}
