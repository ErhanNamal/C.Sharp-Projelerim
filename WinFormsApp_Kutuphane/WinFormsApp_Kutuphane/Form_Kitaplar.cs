using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_Kutuphane.model;

namespace WinFormsApp_Kutuphane
{

    public partial class Form_Kitaplar : Form
    {
        Kutuphane kutuphane = new Kutuphane();
        Kitap kitap1 = new Kitap(b: "1984", y: "George Orwell", t: Kitap.Kitaptur.Roman, s: 400, yy: 1949);
        Kitap kitap2 = new Kitap(b: "Hayvan Çiftliği", y: "George Orwell", t: Kitap.Kitaptur.Roman, s: 500, yy: 1945);
        Kitap kitap3 = new Kitap(b: "Sefiller", y: "Victor Hugo", t: Kitap.Kitaptur.Roman, s: 300, yy: 1862);
        Kitap kitap4 = new Kitap(b: "Sihirli 7", y: "Sahra Doğa Çağdaş", t: Kitap.Kitaptur.Deneme, s: 64, yy: 2024);
        Kitap kitap5 = new Kitap(b: "Lavinia - Aşk Şiirleri", y: "Özdemir Asaf", t: Kitap.Kitaptur.Şiir, s: 35, yy: 2015);
        Kitap kitap6 = new Kitap(b: "1234", y: "özge halil duman", t: Kitap.Kitaptur.Şiir, s: 1, yy: 2024);
        Kitap kitap7 = new Kitap(b: "456789", y: "halil duman", t: Kitap.Kitaptur.Şiir, s: 1, yy: 2024);
        public Form_Kitaplar()
        {
            kutuphane.KitapEkle([kitap1,kitap2,kitap3,kitap4,kitap5,kitap6,kitap7]);
            InitializeComponent();
        }

        private void Form_Kitaplar_Load(object sender, EventArgs e)
        {
            dataGridView_kitaplar.DataSource = kutuphane.TumKitaplariListele();
        }
    }
}
