using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arkaplan_renklendir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkirmizi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnyesil_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnmavi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btngri_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void btnhazirlayan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orange Firması", "www.orangecomputer.com", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

