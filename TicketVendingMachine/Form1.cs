namespace TicketVendingMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chkPay.CheckedItems.Contains("Credit Card"))
            {
                MessageBox.Show("Data Saved:" + Environment.NewLine + cmbTransport.Text + Environment.NewLine +
                cmbDes.Text + Environment.NewLine + chkPay.Text + Environment.NewLine + chkType.Text);
                Form2 ccForm = new Form2();
                ccForm.Show();
            }
            else if (chkPay.CheckedItems.Contains("QR Code"))
            {

                Form3 qrForm = new Form3();
                qrForm.Show();
            }
        }
    }
}