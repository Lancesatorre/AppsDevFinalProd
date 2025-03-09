namespace FinalProdAppsDev
{
    partial class PatientRecordsForm
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
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(64, 80);
            button1.Name = "button1";
            button1.Size = new Size(120, 22);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(317, 208);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(371, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Location = new Point(118, 268);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 2;
            // button2
            // 
            button2.Location = new Point(380, 83);
            button2.Name = "button2";
            button2.Size = new Size(361, 261);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // PatientRecordsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Name = "PatientRecordsForm";
            Text = "PatientRecordsForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;

        private Button button2;
    }
}