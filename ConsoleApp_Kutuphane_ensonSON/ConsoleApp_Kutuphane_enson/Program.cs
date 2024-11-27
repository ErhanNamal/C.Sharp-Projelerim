using System;
using System.Collections.Generic;
//-ANA PROGRAM---
Menu _menu = new Menu();
int secim;
List<Kitap> kitaps;
Kutuphane kutuphane = new Kutuphane();
Kitap kitap1 = new Kitap(b: "1984", y: "George Orwell", t: Kitap.Kitaptur.Roman, s: 400, yy: 1949);
Kitap kitap2 = new Kitap(b: "Hayvan Çiftliği", y: "George Orwell", t: Kitap.Kitaptur.Roman, s: 500, yy: 1945);
Kitap kitap3 = new Kitap(b: "Sefiller", y: "Victor Hugo", t: Kitap.Kitaptur.Roman, s: 300, yy: 1862);
Kitap kitap4 = new Kitap(b: "Sihirli 7", y: "Sahra Doğa Çağdaş", t: Kitap.Kitaptur.Deneme, s: 64, yy: 2024);
Kitap kitap5 = new Kitap(b: "Lavinia - Aşk Şiirleri", y: "Özdemir Asaf", t: Kitap.Kitaptur.Şiir, s: 35, yy: 2015);
Kitap kitap6 = new Kitap(b: "1234", y: "özge halil duman", t: Kitap.Kitaptur.Şiir, s: 1, yy: 2024);
Kitap kitap7 = new Kitap(b: "456789", y: "halil duman", t: Kitap.Kitaptur.Şiir, s: 1, yy: 2024);

List<Kitap> yeniKitaplar = new();
yeniKitaplar = [kitap2, kitap3, kitap4, kitap5, kitap6, kitap7];

kutuphane.KitapEkle(kitap1);
kutuphane.KitapEkle(yeniKitaplar);

List<string> menuoge; //= new List<string>() { "Kitap listele", "kitap ekle", "kitap ara", "kitap guncelle", "kitap sil","cıkış" };
while (true)
{
    Console.Clear();
    menuoge = ["Kitap listele", "kitap ekle", "kitap ara", "kitap guncelle", "kitap sil", "cıkış"];
    secim = _menu.Menum("KÜTÜPHANE 2024", menuoge, [Menu.Renk.Yeşil, Menu.Renk.Kırmızı], 5);

    if (secim == 1)
    {
        Console.WriteLine("Tüm Kitapların Listesi");
        foreach (var k in kutuphane.TumKitaplariListele())
        {
            Console.WriteLine(k);
        }
    }
    if (secim == 2)
    {
        kutuphane.KitapEkle(YenikitapOlustur());
    }
    if (secim == 3)
    {
        menuoge = new List<string>() { "başlığa göre", "yazara göre", "türe göre" };
        int _secim = _menu.Menum("Kitap ara", menuoge, [Menu.Renk.Yeşil, Menu.Renk.Kırmızı], 3);
        Console.Write("kriteri giriniz =>\t".ToUpper());
        string ara = Console.ReadLine();
        Console.WriteLine("\nArama Sonucu:");

        switch (_secim)
        {
            case 1:
                kitaps = kutuphane.BasligaGoreAra(ara);
                kitaps.ForEach(k => Console.WriteLine(k));
                break;
            case 2:
                kitaps = kutuphane.YazaraGoreAra(ara);
                kitaps.ForEach(k => Console.WriteLine(k));
                break;
            case 3:
                Kitap.Kitaptur t = kitapTuruSec();
                kitaps = kutuphane.TureGoreAra(t);
                kitaps.ForEach(k => Console.WriteLine(k));
                break;
            default:
                break;
        }
    }
    if (secim == 4)
    {
        menuoge = new List<string>() { "KitapNoya göre", "başlığa göre" };
        int _secimguncelle = _menu.Menum("Kitap güncelle", menuoge, [Menu.Renk.Yeşil, Menu.Renk.Kırmızı], 3);
        kitaps = kutuphane.TumKitaplariListele();
        int sayguncelle = 0;
        kitaps.ForEach(k => { sayguncelle++; Console.WriteLine($"{sayguncelle}-\t{k}"); });
        switch (_secimguncelle)
        {
            case 1:
                Console.Write("Kitap nosunu giriniz giriniz =>\t".ToUpper());
                int index = Int32.Parse(Console.ReadLine());
                if (kutuphane.KitapGuncelle(kitaps[index - 1], YenikitapOlustur()))
                { Console.WriteLine("güncelleme başarılı".ToUpper()); }
                else { Console.WriteLine("güncelleme başarısız".ToUpper()); }
                break;
            case 2:
                Console.Write("kitap başlığını giriniz =>\t".ToUpper());
                string ara = Console.ReadLine();
                if (kutuphane.KitapGuncelle(ara, YenikitapOlustur()))
                { Console.WriteLine("güncelleme başarılı".ToUpper()); }
                else { Console.WriteLine("güncelleme başarısız".ToUpper()); }

                break;
            default:
                break;
        }

    }
    if (secim == 5)
    {
        menuoge = new List<string>() { "KitapNoya göre", "başlığa göre" };
        int _secimsil = _menu.Menum("Kitap sil", menuoge, [Menu.Renk.Yeşil, Menu.Renk.Kırmızı], 3);
        kitaps = kutuphane.TumKitaplariListele();
        int saysil = 0;
        kitaps.ForEach(k => { saysil++; Console.WriteLine($"{saysil}-\t{k}"); });
        switch (_secimsil)
        {
            case 1:
                Console.Write("Kitap nosunu giriniz giriniz =>\t".ToUpper());
                int index = Int32.Parse(Console.ReadLine());
                if (kutuphane.KitapSil(kitaps[index - 1]))
                { Console.WriteLine("Silme başarılı".ToUpper()); }
                else { Console.WriteLine("Silme başarısız".ToUpper()); }
                break;
            case 2:
                Console.Write("kitap başlığını giriniz =>\t".ToUpper());
                string ara = Console.ReadLine();
                if (kutuphane.KitapSil(ara))
                { Console.WriteLine("Silme başarılı".ToUpper()); }
                else { Console.WriteLine("Silme başarısız".ToUpper()); }

                break;
            default:
                break;
        }
    }
    if (secim == 6)break;
    Console.Write("DEvam etmek için bir tuşa basınız...".ToUpper());Console.ReadKey();
}
Kitap YenikitapOlustur()
{
    Console.Write("Kitabın başlığı =>\t".ToUpper());
    string b = Console.ReadLine();
    Console.Write("Kitabın yazarı =>\t".ToUpper());
    string y = Console.ReadLine();
    Console.WriteLine("Kitabın Turu =>".ToUpper());

    Kitap.Kitaptur t = kitapTuruSec();
    Console.Write("Kitabın sayfa sayısı =>\t".ToUpper());
    int s = Int32.Parse(Console.ReadLine());
    Console.Write("Kitabın yayım yılı =>\t".ToUpper());
    int yy = Int32.Parse(Console.ReadLine());
    return new Kitap(b: b, y: y, t: t, s: s, yy: yy);
}
Kitap.Kitaptur kitapTuruSec()
{
    int say = 0;
    foreach (var item in Enum.GetNames(typeof(Kitap.Kitaptur)))
    {
        say++; Console.WriteLine($"\t{say}-{item}");
    }
    Console.Write($"seciminiz (1..{Enum.GetNames(typeof(Kitap.Kitaptur)).Length})=>");
    int secim = Int32.Parse(Console.ReadLine());
    return Enum.GetValues<Kitap.Kitaptur>()[secim - 1];
}
public class Menu
{
    public enum Renk { 
        Kırmızı,Mavi,Yeşil,Beyaz,Siyah
    }
    public int Menum(string baslik, List<string> ogeler, List<Renk> renkler, int bosluk)
    {
        int _secim;
        string _bosluk="";
        for (int i = 0; i <= bosluk; i++) { _bosluk += "\t"; }
        while (true)
        {          
            var secim = menuOlustur(baslik, ogeler, renkler,_bosluk);
            _secim = 0;
            bool hata = true;
            if (Int32.TryParse(secim, out _secim))
            {
                if (_secim > 0 && _secim < ogeler.Count + 1) { hata = false; }
            }
            if (hata)
            {
                Console.WriteLine($"{_bosluk}hatalı seçim".ToUpper());
                Console.WriteLine($"{_bosluk}Devam etmek için bir tuşa basın...");
                Console.ReadKey();
                Console.Clear();
            }
            else { break; }
        }
        return _secim;
    }
    private string menuOlustur(string baslik, List<string> ogeler, List<Renk> renkler, string bosluk)
    {
        List<ConsoleColor> _renkler = new();
        renkler.ForEach(r =>
        {
            switch (r)
            {
                case Renk.Mavi: _renkler.Add(ConsoleColor.Blue); break;
                case Renk.Yeşil: _renkler.Add(ConsoleColor.Green); break;
                case Renk.Beyaz: _renkler.Add(ConsoleColor.White); break;
                case Renk.Siyah: _renkler.Add(ConsoleColor.Black); break;
                case Renk.Kırmızı: _renkler.Add(ConsoleColor.Red); break;
            }
        }
         );
        int sayac = 0;
        ConsoleColor _default = Console.ForegroundColor;
        Console.ForegroundColor = _renkler[0];
        Console.WriteLine($"{bosluk}{baslik.ToUpper()}");
        Console.ForegroundColor = _default;
        Console.ForegroundColor = _renkler[1];
        Console.WriteLine($"{bosluk}====================");
        Console.ForegroundColor = _default;
        ogeler.ForEach(item => { sayac++; Console.WriteLine($"{bosluk}{sayac}- {item.ToUpper()}"); });
        Console.ForegroundColor = _renkler[1];
        Console.WriteLine($"{bosluk}====================");
        Console.ForegroundColor = _default;
        Console.Write($"{bosluk}Secimiz=>\t");
        return Console.ReadLine();
    }
}
/// <summary>
/// Bir kitabı temsil eder.
/// </summary>
public class Kitap
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

/// <summary>
/// Kütüphane yönetim sistemi sınıfı.
/// </summary>
public class Kutuphane
{
    private List<Kitap> kitaplar = new List<Kitap>();

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
    public void KitapEkle(List<Kitap> kitaps) => kitaplar.AddRange(kitaps);

    /// <summary>
    /// Başlığa göre kitapları arar ve liste olarak döner.
    /// </summary>
    /// <param name="baslik">Aranacak başlık.</param>
    /// <returns>Bulunan kitapların listesi.</returns>
    public List<Kitap> BasligaGoreAra(string baslik)
    {
        return kitaplar
            .Where(k => k.baslik.Contains(baslik, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    /// <summary>
    /// Yazara göre kitapları arar ve liste olarak döner.
    /// </summary>
    /// <param name="yazar">Aranacak yazar adı.</param>
    /// <returns>Bulunan kitapların listesi.</returns>
    public List<Kitap> YazaraGoreAra(string yazar)
    {
        return kitaplar
            .Where(k => k.yazar.Contains(yazar, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    /// <summary>
    /// Türe göre kitapları arar ve liste olarak döner.
    /// </summary>
    /// <param name="tur">Aranacak kitap türü.</param>
    /// <returns>Bulunan kitapların listesi.</returns>
    public List<Kitap> TureGoreAra(Kitap.Kitaptur tur)
    {
        return kitaplar.Where(k => k.tur == tur).ToList();
    }

    /// <summary>
    /// Yayın yılına göre kitapları arar ve liste olarak döner.
    /// </summary>
    /// <param name="yayinYili">Aranacak yayın yılı.</param>
    /// <returns>Bulunan kitapların listesi.</returns>
    public List<Kitap> YayinaGoreAra(int yayinYili)
    {
        return kitaplar.Where(k => k.yayinYili == yayinYili).ToList();
    }

    /// <summary>
    /// Kütüphanedeki tüm kitapları listeler.
    /// </summary>
    /// <returns>Kütüphanedeki kitapların listesi.</returns>
    public List<Kitap> TumKitaplariListele()
    {
        return kitaplar;
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

    /// <summary>
    /// Kitap silme.
    /// </summary>
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
    /// <summary>
    /// Kitabı başlığa göre siler.
    /// </summary>
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

    /// <summary>
    /// Kitabı yazara göre siler.
    /// </summary>
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


