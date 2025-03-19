using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProdAppsDev
{
    public partial class QRCodePage : Form
    {
        public QRCodePage()
        {
            InitializeComponent();
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void GenerateQRCode(string text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(10); // 10 is the pixel per module (size)

            //siticonePictureBox1.Image = qrCodeImage;
        }
        private void QRCodePage_Load(object sender, EventArgs e)
        {
            GenerateQRCode("https://universityofcebu.instructure.com/"); // Change this to your text or URL
        }
    }
}
