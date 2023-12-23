using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_ilkornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int vakifbank = 3;
            // int kuzeyboru = 0;


            /* if (vakifbank > kuzeyboru)
            {
                MessageBox.Show("Vakıfbank kazandı");
                MessageBox.Show("Tebrikler");
            }

            else
            {
                MessageBox.Show("Kuzeyboru kazandı");

            }
           */

            int yas;
            yas = Convert.ToInt32(textBox1.Text);
            if(yas>=18)
            {
                MessageBox.Show("Ehliyet alabilirsiniz");
            }
            else
            {
                MessageBox.Show("Ehliyet alamazsınız");
            }

            
        
        }
    }
}
