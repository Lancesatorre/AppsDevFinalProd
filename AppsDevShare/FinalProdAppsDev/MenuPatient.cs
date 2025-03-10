using System;
using System.Collections;
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
    public partial class MenuPatient : Form
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

            //this.Visible = false;
            //LoginPage login = new LoginPage();
            //login.Show();

            Application.Exit();

        }

        private void SetButtonStyles(SiticoneNetCoreUI.SiticoneButton activeButton, params SiticoneNetCoreUI.SiticoneButton[] otherButtons)
        {

            activeButton.ButtonBackColor = Color.White;
            activeButton.Font = new Font(activeButton.Font, FontStyle.Bold);
            activeButton.Size = new Size(170, 45);


            foreach (var btn in otherButtons)
            {
                btn.Font = new Font(activeButton.Font, FontStyle.Regular);
                btn.ButtonBackColor = Color.FromArgb(128, 255, 255, 255);
                btn.Size = new Size(156, 41);
                btn.BorderColor = Color.White;
            }
        }

        private void PatientRecords_MouseClick(object sender, MouseEventArgs e)
        {

            MainPatientRecordPanel.Visible = true;
            SetButtonStyles(PatientRecords, BAppointments, BScanQr, BBilling);
        }

        private void BAppointments_MouseClick(object sender, MouseEventArgs e)
        {
            MainPatientRecordPanel.Visible = false;
            SetButtonStyles(BAppointments, PatientRecords, BScanQr, BBilling);
        }

        private void BScanQr_MouseClick(object sender, MouseEventArgs e)
        {
            MainPatientRecordPanel.Visible = false;
            SetButtonStyles(BScanQr, BAppointments, PatientRecords, BBilling);
        }

        private void BBilling_MouseClick(object sender, MouseEventArgs e)
        {
            MainPatientRecordPanel.Visible = false;
            SetButtonStyles(BBilling, PatientRecords, BAppointments, BScanQr);
        }

        private void TBSearchBar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BLogout_MouseClick(object sender, MouseEventArgs e)
        {
            Panel panel = new Panel
            {
                Size = new Size(775, 80),
                BackColor = Color.FromArgb(210, 225, 237),
                BorderStyle = BorderStyle.None,
                Margin = new Padding(10, 8, 1, 4)


            };

            Label titleLabel = new Label
            {
                Text = $"No. {panelList.Count + 1}",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(25, 30)
            };



            Button UpdateButton = new Button
            {
                BackColor = Color.FromArgb(9, 195, 51),
                Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(675, 28),
                Name = "update",
                Size = new Size(73, 33),
                TabIndex = 7,
                Text = "Update",
                UseVisualStyleBackColor = false

            };

            Button viewButton = new Button
            {
                BackColor = Color.FromArgb(58, 94, 116),
                Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(600, 28),
                Name = "View",
                Size = new Size(73, 33),
                TabIndex = 7,
                Text = "View",
                UseVisualStyleBackColor = false

            };

            panel.Controls.Add(titleLabel);
            panel.Controls.Add(viewButton);
            panel.Controls.Add(UpdateButton);

            panelList.Add(panel);
            FlowPanel.Controls.Add(panel);

        }

        private void AddPatientB_Click(object sender, EventArgs e)
        {

        }

        private void AddPatientB_MouseClick(object sender, MouseEventArgs e)
        {
            FlowPanel.Visible = false;
            PDetailsPatient.Visible = true;
        }

        private void BSaveDetails_MouseClick(object sender, MouseEventArgs e)
        {
            PDetailsPatient.Visible = false;
            FlowPanel.Visible = true;


          
        }
    }
}
