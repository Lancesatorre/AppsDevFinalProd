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
    public partial class MenuPatient: Form
    {
        public MenuPatient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            LoginPage login = new LoginPage();
            login.Show();


        }

        private void BPatientRec_MouseClick(object sender, MouseEventArgs e)
        {
            SetButtonStyles(BPatientRec, BAppointment, BQrCode, BBillings);
        }

        private void BAppointment_MouseClick(object sender, MouseEventArgs e)
        {
            SetButtonStyles(BAppointment, BPatientRec, BQrCode, BBillings);
        }

        private void BQrCode_MouseClick(object sender, MouseEventArgs e)
        {
            SetButtonStyles(BQrCode, BPatientRec, BAppointment, BBillings);
        }

        private void BBillings_MouseClick(object sender, MouseEventArgs e)
        {
            SetButtonStyles(BBillings, BPatientRec, BAppointment, BQrCode);
        }

        private void SetButtonStyles(Button activeButton, params Button[] otherButtons)
        {
            activeButton.FlatStyle = FlatStyle.System;
            activeButton.UseVisualStyleBackColor = true;
            activeButton.BackColor = Color.White;
            activeButton.Font = new Font(activeButton.Font, FontStyle.Bold);
            activeButton.Size = new Size(170, 45);


            foreach (var btn in otherButtons)
            {
                btn.Font = new Font(activeButton.Font, FontStyle.Regular);
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = Color.FromArgb(128, 255, 255, 255);
                btn.Size = new Size(156, 41);
            }
        }
    }
}
