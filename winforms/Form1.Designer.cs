using System.Reflection;

namespace WinFormsApp_Kutuphane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_kitaplar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_kitaplar
            // 
            button_kitaplar.Location = new Point(12, 220);
            button_kitaplar.Name = "button_kitaplar";
            button_kitaplar.Size = new Size(319, 55);
            button_kitaplar.TabIndex = 0;
            button_kitaplar.Text = "Kitaplar";
            button_kitaplar.UseVisualStyleBackColor = true;
            button_kitaplar.Click += button_kitaplar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(161, 19);
            label1.Name = "label1";
            label1.Size = new Size(170, 37);
            label1.TabIndex = 1;
            label1.Text = "KÜTÜPHANE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.kitaplar;
            pictureBox1.Location = new Point(12, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 287);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button_kitaplar);
            Name = "Form1";
            Text = "Kütüphane";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_kitaplar;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
