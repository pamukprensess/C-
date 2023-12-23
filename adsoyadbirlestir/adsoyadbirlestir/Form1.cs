using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adsoyadbirlestir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbirlestir_Click(object sender, EventArgs e)
        {
            txtadsoyad.Text = txtad.Text + " " + txtsoyad.Text;
            MessageBox.Show("Tebrikler ad soyad birleştirdiniz");
        }
    }
}
