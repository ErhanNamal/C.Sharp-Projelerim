//-- ANA PROGRAM --DENEME
using System.Linq;
using System.Xml;

Kitap k = new Kitap("çiçek senfonisi1", "özdemir asaf", 101, Kitap.tur.Siir);
Kitap k2 = new Kitap("çiçek senfonisi2", "özdemir asaf", 102, Kitap.tur.Siir);
Kitap k3 = new Kitap("çiçek senfonisi3", "özdemir asaf", 103, Kitap.tur.Siir);
Kitap k4 = new Kitap("çiçek senfonisi4", "özdemir asaf", 104, Kitap.tur.Siir);
Kitap k5 = new("denemeler", "özge halil duman", 1, Kitap.tur.Deneme);

Kutuphane _ktphane = new Kutuphane();
_ktphane.kitap_ekle(k);
_ktphane.kitap_ekle(k2);
_ktphane.kitap_ekle(k3);
_ktphane.kitap_ekle(k4);
_ktphane.kitap_ekle(k5);

var secilen_kitap = _ktphane.kitap_listele()[2];
_ktphane.kitap_guncelle(secilen_kitap, k5);
_ktphane.kitap_guncelle(0, k5);
_ktphane.kitap_sil("4");

foreach (Kitap ktp in _ktphane.kitap_listele())
{
    Console.WriteLine(ktp);
}

///<summary>
/// Bir Kitabın özelliklerini ve metotlarını içerir
///</summary>
public class Kitap
{   //ozellikler=>//baslik//yazar//sayfa
    //metotlar=ekleme//silme//listeleme//değiştirme//verme//gerialma
    /// <summary>
    /// Kitap oluşturmanın kısa yolu
    /// </summary>
    /// <param name="b">kitabın başlığı</param>
    /// <param name="y">kitabın yazarı</param>
    /// <param name="s">kitabın sayfa sayısı</param>
    public enum tur
    {
        Siir,
        Roman,
        Hikaye,
        Deneme
    }
    public Kitap(string b, string y, int s, tur kitapturu)
    {
        baslik = b;
        yazar = y;
        sayfa = s;
        kitaptur = kitapturu;
    }

    private string _baslik;
    private string _yazar;
    private int _sayfa;

    /// <summary>
    /// bir kitabın başlık bilgisi.(Buyuk harfe çevirir)
    /// </summary>  
    public tur kitaptur;
    public string baslik
    {
        get => _baslik;
        set { _baslik = value.ToUpper(); }
    }
    public string yazar
    {
        get => _yazar;
        set { _yazar = value.ToUpper(); }
    }
    public int sayfa
    {
        get => _sayfa;
        set
        {
            _sayfa = value > 5 ? value : 0;
        }
    }
    public override string ToString()
    {
        return $"{baslik}-{yazar}-{kitaptur} ({sayfa})";
    }
}

public class Kutuphane
{//kitap ->ekleme-listeleme-guncelleme-silme
    private List<Kitap> kitaplar = new List<Kitap>();
    public void kitap_ekle(Kitap k)
    {
        kitaplar.Add(k);
    }
    public List<Kitap> kitap_listele()
    {
        return kitaplar;
    }
    public void kitap_guncelle(Kitap orj_kitap, Kitap yeni_kitap)
    {
        int aranan = kitaplar.IndexOf(orj_kitap);
        if (aranan != -1)
        {
            kitaplar[aranan] = yeni_kitap;
        }
    }
    public void kitap_guncelle(int secilen, Kitap yeni_kitap)
    {
        kitaplar[secilen] = yeni_kitap;
    }
    public void kitap_sil(Kitap secilen_kitap)
    {
        kitaplar.Remove(secilen_kitap);
    }

    public void kitap_sil(int secilen_kitapNo)
    {
        kitaplar.RemoveAt(secilen_kitapNo);
    }

    public void kitap_sil(string secilen_kitap)
    {
       
    }
}
