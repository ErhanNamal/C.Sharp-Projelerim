using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using WinFormsApp2.model;

namespace WinFormsApp2.model
{
    internal class Kutuphane
    {
        private BindingList<Kitap> kitaplar = new BindingList<Kitap>();

        /// <summary>
        /// Kütüphaneye yeni bir kitap ekler.
        /// </summary>
        /// <param name="kitap">Eklenecek kitap.</param>
        public void KitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }
        /// <summary>
        /// Kütüphaneye birden fazla kitap ekler.
        /// </summary>
        /// <param name="kitaps">Eklenecek kitapların listesi.</param>
        public void KitapEkle(List<Kitap> kitaps) => kitaps.ForEach(x => kitaplar.Add(x));

        /// <summary>
        /// Başlığa göre kitapları arar ve liste olarak döner.
        /// </summary>
        /// <param name="baslik">Aranacak başlık.</param>
        /// <returns>Bulunan kitapların listesi.</returns>
        public BindingList<Kitap> BasligaGoreAra(string baslik)
        {
            return new BindingList<Kitap>(kitaplar
                .Where(k => k.baslik.Contains(baslik, StringComparison.OrdinalIgnoreCase))
                .ToList());
        }

        /// <summary>
        /// Yazara göre kitapları arar ve liste olarak döner.
        /// </summary>
        /// <param name="yazar">Aranacak yazar adı.</param>
        /// <returns>Bulunan kitapların listesi.</returns>
        public BindingList<Kitap> YazaraGoreAra(string yazar)
        {
            return new BindingList<Kitap>(kitaplar
                .Where(k => k.yazar.Contains(yazar, StringComparison.OrdinalIgnoreCase))
                .ToList());
        }

        /// <summary>
        /// Türe göre kitapları arar ve liste olarak döner.
        /// </summary>
        /// <param name="tur">Aranacak kitap türü.</param>
        /// <returns>Bulunan kitapların listesi.</returns>
        public BindingList<Kitap> TureGoreAra(Kitap.Kitaptur tur)
        {
            return new BindingList<Kitap>(kitaplar.Where(k => k.tur == tur).ToList());
        }

        /// <summary>
        /// Yayın yılına göre kitapları arar ve liste olarak döner.
        /// </summary>
        /// <param name="yayinYili">Aranacak yayın yılı.</param>
        /// <returns>Bulunan kitapların listesi.</returns>
        public BindingList<Kitap> YayinaGoreAra(int yayinYili)
        {
            return new BindingList<Kitap>(kitaplar.Where(k => k.yayinYili == yayinYili).ToList());
        }

        /// <summary>
        /// Kütüphanedeki tüm kitapları listeler.
        /// </summary>
        /// <returns>Kütüphanedeki kitapların listesi.</returns>
        public BindingList<Kitap> TumKitaplariListele()
        {
            return new BindingList<Kitap>(kitaplar);
        }

        /// <summary>
        /// Kitap günceller.
        /// </summary>
        public bool KitapGuncelle(Kitap eskiKitap, Kitap yeniKitap)
        {
            var kitap = kitaplar.FirstOrDefault(k => k == eskiKitap);
            if (kitap != null)
            {
                kitap.baslik = yeniKitap.baslik;
                kitap.yazar = yeniKitap.yazar;
                kitap.tur = yeniKitap.tur;
                kitap.sayfa = yeniKitap.sayfa;
                kitap.yayinYili = yeniKitap.yayinYili;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Kitabı başlığa göre günceller.
        /// </summary>
        public bool KitapGuncelle(string eskiBaslik, Kitap yeniKitap)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.baslik.Contains(eskiBaslik, StringComparison.OrdinalIgnoreCase));
            if (kitap != null)
            {
                kitap.baslik = yeniKitap.baslik;
                kitap.yazar = yeniKitap.yazar;
                kitap.tur = yeniKitap.tur;
                kitap.sayfa = yeniKitap.sayfa;
                kitap.yayinYili = yeniKitap.yayinYili;
                return true;
            }
            return false;
        }

        /// <summary> Kitap silme. </summary>
        public bool KitapSil(Kitap silinecek_kitap)
        {
            var kitap = kitaplar.FirstOrDefault(k => k == silinecek_kitap);
            if (kitap != null)
            {
                kitaplar.Remove(kitap);
                return true;
            }
            return false;
        }
        /// <summary> Kitabı başlığa göre siler. </summary>
        public bool KitapSil(string baslik)
        {
            //var kitap = kitaplar.FirstOrDefault(k => k.baslik.Equals(baslik, StringComparison.OrdinalIgnoreCase));
            var kitap = kitaplar.FirstOrDefault(k => k.baslik.Contains(baslik, StringComparison.OrdinalIgnoreCase));
            if (kitap != null)
            {
                kitaplar.Remove(kitap);
                return true;
            }
            return false;
        }

        /// <summary> Kitabı yazara göre siler. </summary>
        public bool KitapSilByYazar(string yazar)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.yazar.Equals(yazar, StringComparison.OrdinalIgnoreCase));
            if (kitap != null)
            {
                kitaplar.Remove(kitap);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Kitabı türe göre siler.
        /// </summary>
        public bool KitapSilByTur(Kitap.Kitaptur tur)
        {
            var kitap = kitaplar.FirstOrDefault(k => k.tur == tur);
            if (kitap != null)
            {
                kitaplar.Remove(kitap);
                return true;
            }
            return false;
        }
    }
}