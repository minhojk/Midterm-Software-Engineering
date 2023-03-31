using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketVendingMachine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Saved:" + Environment.NewLine + textBox1.Text + Environment.NewLine +
                textBox2.Text + Environment.NewLine + textBox3.Text + Environment.NewLine + textBox4.Text + Environment.NewLine + textBox5.Text);
            this.Close();
        }
    }
}
