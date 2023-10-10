using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_ornek_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTikla_MouseEnter(object sender, EventArgs e)
        {
            btnTikla.BackColor = Color.Blue;
            btnTikla.ForeColor = Color.White;
        }

        private void btnTikla_MouseLeave(object sender, EventArgs e)
        {
            btnTikla.BackColor= Color.Red;
            btnTikla.ForeColor = Color.White;
        }

        private void btnTikla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nesne Tabanlı Programlama");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTikla.BackColor = Color.Red;
            btnTikla.ForeColor = Color.White;
        }
    }
}
