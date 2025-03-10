namespace FinalProdAppsDev
{
    partial class QRCodePage
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
            button2 = new Button();
            pictureBox1 = new PictureBox();

            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();

            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(35, 24);
            button1.Name = "button1";
            button1.Size = new Size(204, 97);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(437, 40);
            button2.Name = "button2";
            button2.Size = new Size(76, 94);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 

            pictureBox1.Image = Properties.Resources.Background;
            pictureBox1.Location = new Point(644, 353);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 81);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Background;
            pictureBox2.Location = new Point(499, 352);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 81);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;

            pictureBox1.Image = Properties.Resources.eyeClose;
            pictureBox1.Location = new Point(74, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 259);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(467, 192);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 23);
            comboBox1.TabIndex = 3;

            // 
            // QRCodePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(pictureBox2);

            Controls.Add(comboBox1);

            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "QRCodePage";
            Text = "QRCodePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();

            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();

            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;

        private PictureBox pictureBox2;

        private ComboBox comboBox1;

    }
}