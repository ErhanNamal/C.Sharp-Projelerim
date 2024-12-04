using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.model
{
    internal class Kitap
    {
        private string _baslik;
        private string _yazar;
        private int _sayfa;
        private int _yayinYili;
        public enum Kitaptur
        {
            Roman,
            Hikaye,
            Deneme,
            Şiir
        }
        /// <summary>
        /// Kitabın başlığı.
        /// </summary>
        public string baslik
        {
            get => _baslik;
            set { _baslik = value.ToUpper(); }
        }

        /// <summary>
        /// Kitabın yazarı.
        /// </summary>
        public string yazar
        {
            get => _yazar;
            set { _yazar = value.ToUpper(); }
        }
        public Kitaptur tur { get; set; }
        /// <summary>
        /// Kitabın yayın yılı.
        /// </summary>
        public int sayfa
        {
            get => _sayfa;
            set { _sayfa = value > 0 ? value : 0; }
        }
        public int yayinYili
        {
            get => _yayinYili;
            set
            {
                _yayinYili = value > 1000 || value < DateTime.Now.Year ? value : 1000;

            }
        }

        /// <summary>
        /// Kitap mevcut durumda ödünç alınmış mı?
        /// </summary>
        public bool OduncAlindiMi { get; private set; }

        /// <summary>
        /// yeni bir kitap oluşturmaya yarar
        /// </summary>
        /// <param name="b">Kitabın başlığı</param>
        /// <param name="y">Kitabın yazaeı</param>
        /// <param name="t">Kitabın turu</param>
        /// <param name="s">Kitabın sayfa sayısı</param>
        /// <param name="yy">Kitabın basim tarihi</param>
        public Kitap(string b, string y, Kitaptur t, int s, int yy)
        {
            baslik = b;
            yazar = y;
            tur = t;
            sayfa = s;
            yayinYili = yy;
        }
        /// <summary>
        /// Kitap bilgilerini içeren bir açıklama döndürür.
        /// </summary>
        /// <returns>Kitap başlığı, yazarı ve yayın yılı bilgisi.</returns>
        public override string ToString()
        {
            return $"{tur}\t=> {baslik}- {yazar} \t({yayinYili}-{sayfa})";
        }

        /// <summary>
        /// Kitabı ödünç alır.
        /// </summary>
        /// <exception cref="InvalidOperationException">Kitap zaten ödünç alınmışsa fırlatılır.</exception>
        public void OduncAl()
        {
            if (OduncAlindiMi)
                throw new InvalidOperationException("Kitap zaten ödünç alınmış.");
            OduncAlindiMi = true;
        }

        /// <summary>
        /// Kitabı geri iade eder.
        /// </summary>
        /// <exception cref="InvalidOperationException">Kitap zaten iade edilmişse fırlatılır.</exception>
        public void IadeEt()
        {
            if (!OduncAlindiMi)
                throw new InvalidOperationException("Kitap zaten iade edilmiş.");
            OduncAlindiMi = false;
        }
    }
}
