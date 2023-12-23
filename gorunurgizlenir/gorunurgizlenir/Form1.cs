using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorunurgizlenir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngoster_Click(object sender, EventArgs e)
        {
            pctrmeb.Visible = true;
            MessageBox.Show("Göster butonuna tıklandı.");

            
        }

        private void btngizle_Click(object sender, EventArgs e)
        {
            pctrmeb.Visible = false;
            MessageBox.Show("Gizle butonuna tıklandı.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btngizle.BackColor = Color.Red;
            btngoster.BackColor = Color.Green;
            this.Text = "Görün ve Kaybol";
        }

        private void btngoster_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
