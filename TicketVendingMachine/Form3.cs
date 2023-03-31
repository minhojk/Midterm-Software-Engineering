using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.Common;
using ZXing;
using ZXing.Windows.Compatibility;

namespace TicketVendingMachine
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            QRcode("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }

        private void QRcode(string text)
        {
            // Create QR code writer
            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = 255,
                    Width = 434,
                    Margin = 0
                }
            };

            // Encode text into QR code
            var matrix = writer.Encode(text);

            // Create Bitmap from BitMatrix
            var bitmap = new Bitmap(matrix.Width, matrix.Height);
            for (int x = 0; x < matrix.Width; x++)
            {
                for (int y = 0; y < matrix.Height; y++)
                {
                    bitmap.SetPixel(x, y, matrix[x, y] ? Color.Black : Color.White);
                }
            }

            // Set PictureBox's Image to the generated Bitmap
            pictureBox2.Image = bitmap;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scanned");
            this.Close();
        }
    }
}
