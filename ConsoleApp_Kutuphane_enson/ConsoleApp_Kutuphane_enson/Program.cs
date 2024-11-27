Kutuphane kutuphane = new Kutuphane();
int secim= 0;
while (true)
{
    secim = Menu.kutuphaneSecimMenusu();
    if (secim == 0) { break; }
    else if (secim == 1)
    {
        Console.WriteLine("Tüm Kitapların Listesi");
        foreach (var k in kutuphane.TumKitaplariListele())
        {
            Console.WriteLine(k.ToString());
        }
    }
    else if (secim == 2)
    {
        

    }
    else if (secim == 3)
    {

    }
    else if (secim == 4)
    {

    }
    else if (secim == 5)
    {

    }
    else
    {
        Console.WriteLine("Lütfen Geçerli Bir Sayı Giriniz!");
    }
}


//-ana program
Kitap kitap1 = new Kitap(b: "1984", y: "George Orwell", t: Kitap.Kitaptur.Roman, s: 400, yy: 1949);
Kitap kitap2 = new Kitap(b: "Hayvan Çiftliği", y: "George Orwell", t: Kitap.Kitaptur.Roman, s: 500, yy: 1945);
Kitap kitap3 = new Kitap(b: "Sefiller", y: "Victor Hugo", t: Kitap.Kitaptur.Roman, s: 300, yy: 1862);
Kitap kitap4 = new Kitap(b: "Sihirli 7", y: "Sahra Doğa Çağdaş", t: Kitap.Kitaptur.Deneme, s: 64, yy: 2024);
Kitap kitap5 = new Kitap(b: "Lavinia - Aşk Şiirleri", y: "Özdemir Asaf", t: Kitap.Kitaptur.Şiir, s: 35, yy: 2015);
Kitap kitapUpdate = new Kitap(b: "12345", y: "özge halil duman", t: Kitap.Kitaptur.Şiir, s: 1, yy: 2024);
Kitap kitapDel = new Kitap(b: "456789", y: "halil duman", t: Kitap.Kitaptur.Şiir, s: 1, yy: 2024);
/*
// Kitaplar ekleniyor
List<Kitap> yeniKitaplar = new();
yeniKitaplar = [kitap2, kitap3, kitap4, kitap5];

kutuphane.KitapEkle(kitap1);
kutuphane.KitapEkle(kitapUpdate);
kutuphane.KitapEkle(kitapDel);
kutuphane.KitapEkle(yeniKitaplar);
Console.WriteLine("Tüm Kitapların Listesi");
foreach (var k in kutuphane.TumKitaplariListele())
{
    Console.WriteLine(k);
}
var romanlar = kutuphane.TureGoreAra(Kitap.Kitaptur.Şiir);
Console.WriteLine("\nŞiir Türündeki Kitaplar:");
romanlar.ForEach(k => Console.WriteLine(k));

// Yazara göre arama
var yazarKitaplari = kutuphane.YazaraGoreAra("George");
Console.WriteLine("\nGeorge'un kitapları:");
yazarKitaplari.ForEach(k => Console.WriteLine(k));

// Kitabı yazara göre güncelleme
Console.WriteLine("\nBaşlığı kitabını güncelleme:");
var yeniKitap = new Kitap("Nesnenin Yeni Koleleri 123456", "Ö. Halil DUMAN", Kitap.Kitaptur.Deneme, 250, 2024);
if (kutuphane.KitapGuncelle("1234", yeniKitap))
    Console.WriteLine("Güncelleme başarılı!");
else
    Console.WriteLine("Güncelleme başarısız!");
Console.WriteLine("\nGüncellenen Yeni Liste");
foreach (var k in kutuphane.TumKitaplariListele())
{
    Console.WriteLine(k);
}
// Kitap başlığa göre silme
Console.WriteLine("\n Başlığında '456' geçen kitabı silme:");
if (kutuphane.KitapSil("456"))
    Console.WriteLine("Silme başarılı!");
else
    Console.WriteLine("Silme başarısız!");
Console.WriteLine("\n Kütüphanenin EN SON KİTAP LİSTESİ");
foreach (var k in kutuphane.TumKitaplariListele())
{
    Console.WriteLine(k);
}
*/
public class Menu()
{
    static public int kutuphaneSecimMenusu() 
    { 
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\tKUTUPHANE");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("_______________________");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Kitapları Listele");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("2-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Yeni Kitap Ekle");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("3-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Kitap Ara");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("4-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Kitap Güncelle");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("5-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Kitap Sil");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("0-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Çıkış");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("_______________________");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Seçiminiz:");
        Console.ForegroundColor = ConsoleColor.White;
        return Int32.Parse(Console.ReadLine());
    }

    static public int kitapAraMenusu()
    {
        //Baslığa Göre Ara
        //Yazara Göre Ara
        //Türe Göre Ara
        //Yayına Göre Ara
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\tMENÜ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("_______________________");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Başlığa Göre Ara");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("2-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Yazara Göre Ara");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("3-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Türe Göre Ara");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("4-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Yayına Göre Ara");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("0-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Çıkış");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("_______________________");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Seçiminiz:");
        Console.ForegroundColor = ConsoleColor.White;
        return Int32.Parse(Console.ReadLine());
    }

    static public int kitapSilmeMenusu()
    {
        //KitapSil
        //KitapSilByYazar
        //KitapSilByTur
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\tMENÜ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("_______________________");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("1-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Kitap Sil");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("2-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Yazara Göre Sil");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("3-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Türe Göre Sil");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("0-");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Çıkış");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("_______________________");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Seçiminiz:");
        Console.ForegroundColor = ConsoleColor.White;
        return Int32.Parse(Console.ReadLine());
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
            _yayinYili = value > 1000 || value < DateTime.Now.Year+1 ? value : 1000;
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
        return $"{tur}\t=> {baslik}\t\t\t{yazar} \t({yayinYili}-{sayfa})";
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



