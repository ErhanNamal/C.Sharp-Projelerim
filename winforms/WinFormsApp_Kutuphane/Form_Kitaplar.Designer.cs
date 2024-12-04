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
            Column_kAd = new DataGridViewTextBoxColumn();
            Column_kYazar = new DataGridViewTextBoxColumn();
            Column_kTur = new DataGridViewComboBoxColumn();
            Column_kSayfa = new DataGridViewTextBoxColumn();
            Column_yayinYili = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView_kitaplar).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_kitaplar
            // 
            dataGridView_kitaplar.AllowUserToAddRows = false;
            dataGridView_kitaplar.AllowUserToDeleteRows = false;
            dataGridView_kitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_kitaplar.Columns.AddRange(new DataGridViewColumn[] { Column_kAd, Column_kYazar, Column_kTur, Column_kSayfa, Column_yayinYili });
            dataGridView_kitaplar.Location = new Point(0, 0);
            dataGridView_kitaplar.Name = "dataGridView_kitaplar";
            dataGridView_kitaplar.Size = new Size(553, 452);
            dataGridView_kitaplar.TabIndex = 0;
            // 
            // Column_kAd
            // 
            Column_kAd.HeaderText = "Kitap Adı";
            Column_kAd.Name = "Column_kAd";
            // 
            // Column_kYazar
            // 
            Column_kYazar.HeaderText = "Yazar";
            Column_kYazar.Name = "Column_kYazar";
            // 
            // Column_kTur
            // 
            Column_kTur.HeaderText = "Türü";
            Column_kTur.Name = "Column_kTur";
            // 
            // Column_kSayfa
            // 
            Column_kSayfa.HeaderText = "Sayfa";
            Column_kSayfa.Name = "Column_kSayfa";
            // 
            // Column_yayinYili
            // 
            Column_yayinYili.HeaderText = "Yayın Yılı";
            Column_yayinYili.Name = "Column_yayinYili";
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
        private DataGridViewTextBoxColumn Column_kAd;
        private DataGridViewTextBoxColumn Column_kYazar;
        private DataGridViewComboBoxColumn Column_kTur;
        private DataGridViewTextBoxColumn Column_kSayfa;
        private DataGridViewTextBoxColumn Column_yayinYili;
    }
}