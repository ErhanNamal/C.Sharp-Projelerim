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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button_uyeler = new Button();
            button_kitaplar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button_kitapİslem = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_uyeler
            // 
            button_uyeler.Location = new Point(12, 226);
            button_uyeler.Name = "button_uyeler";
            button_uyeler.Size = new Size(154, 85);
            button_uyeler.TabIndex = 0;
            button_uyeler.Text = "Üyeler";
            button_uyeler.UseVisualStyleBackColor = true;
            // 
            // button_kitaplar
            // 
            button_kitaplar.Location = new Point(542, 226);
            button_kitaplar.Name = "button_kitaplar";
            button_kitaplar.Size = new Size(154, 85);
            button_kitaplar.TabIndex = 1;
            button_kitaplar.Text = "Kitaplar";
            button_kitaplar.UseVisualStyleBackColor = true;
            button_kitaplar.Click += button_kitaplar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(219, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 50);
            label1.TabIndex = 2;
            label1.Text = "KÜTÜPHANE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(236, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button_kitapİslem
            // 
            button_kitapİslem.Location = new Point(273, 226);
            button_kitapİslem.Name = "button_kitapİslem";
            button_kitapİslem.Size = new Size(154, 85);
            button_kitapİslem.TabIndex = 4;
            button_kitapİslem.Text = "Kitap İşlemler";
            button_kitapİslem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 323);
            Controls.Add(button_kitapİslem);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button_kitaplar);
            Controls.Add(button_uyeler);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_uyeler;
        private Button button_kitaplar;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button_kitapİslem;
    }
}
