namespace WinFormsApp_Kutuphane
{
    partial class Form_Kitaplar
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
            dataGridView_kitaplar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_kitaplar).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_kitaplar
            // 
            dataGridView_kitaplar.AllowUserToAddRows = false;
            dataGridView_kitaplar.AllowUserToDeleteRows = false;
            dataGridView_kitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_kitaplar.Location = new Point(-2, -1);
            dataGridView_kitaplar.Name = "dataGridView_kitaplar";
            dataGridView_kitaplar.ReadOnly = true;
            dataGridView_kitaplar.Size = new Size(586, 448);
            dataGridView_kitaplar.TabIndex = 0;
            // 
            // Form_Kitaplar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_kitaplar);
            Name = "Form_Kitaplar";
            Text = "Form_Kitaplar";
            Load += Form_Kitaplar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_kitaplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_kitaplar;
    }
}