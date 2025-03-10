namespace FinalProdAppsDev
{
    partial class Appointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            siticoneCloseButton1 = new SiticoneNetCoreUI.SiticoneCloseButton();
            SuspendLayout();
            // 
            // siticoneCloseButton1
            // 
            siticoneCloseButton1.BackColor = Color.Transparent;
            siticoneCloseButton1.CountdownFont = new Font("Segoe UI", 9F);
            siticoneCloseButton1.Cursor = Cursors.Default;
            siticoneCloseButton1.EnableSound = false;
            siticoneCloseButton1.Location = new Point(373, 125);
            siticoneCloseButton1.Name = "siticoneCloseButton1";
            siticoneCloseButton1.Size = new Size(276, 276);
            siticoneCloseButton1.TabIndex = 0;
            siticoneCloseButton1.Text = "siticoneCloseButton1";
            siticoneCloseButton1.TooltipText = "Close button";
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(siticoneCloseButton1);
            Name = "Appointment";
            Text = "Appointment";
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticoneCloseButton siticoneCloseButton1;
    }
}