namespace WinFormsApp_Kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_kitaplar_Click(object sender, EventArgs e)
        {
            Form_Kitaplar kitaplar = new Form_Kitaplar();
            kitaplar.ShowDialog();
        }
    }
}
