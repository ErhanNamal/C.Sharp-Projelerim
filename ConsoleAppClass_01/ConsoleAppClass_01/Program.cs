
//sınıfdan nesne türetme
Sinif amp10A = new Sinif();
Sinif amp10B = new Sinif();
Sinif secilenSNF = new Sinif();
int secim = 0;
string ad;
string soyad;
while (true)
{
    secim = Sinif.sinifSecimMenusu();
    if (secim == 0) { break; }
    //if (secim == 1) { secilenSNF = amp10A; }
    //if (secim == 2) { secilenSNF = amp10B; }
    secilenSNF = secim == 1 ? amp10A : amp10B;//yukardaki iki satırın işini tek başına yapar
    while (true)
    {
        secim = Sinif.islemMenusu();
        if (secim == 0) { break; }
        if (secim == 1)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Ogrenci Adı\t:");
            ad = Console.ReadLine();
            Console.Write("Ogrenci Soyadı\t:");
            soyad = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            secilenSNF.ogrenciEkle(ad + " " + soyad);
        }
        else if (secim == 3)
        {
            secilenSNF.ogrenciListele("\tSınıf Listesi");
            Console.Write("Silmek İstediğiniz Numarayı Giriniz=>");
            
            
        }
        else
        {
            secilenSNF.ogrenciListele("\tSINIF LİSTESİ");
            Console.WriteLine("Devam etmek için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}

class Sinif
{
    static public int sinifSecimMenusu()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\tSINIF MENUSU");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\tAMP-10/A\t(1)");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\tAMP-10/B\t(2)");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\tÇıkış\t\t(0)");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\tSeçiminiz=>\t");
        return Int32.Parse(Console.ReadLine());
    }
    static public int islemMenusu() 
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\tİSLEM MENUSU");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\tOgrenci Ekle\t(1)");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\tOgrenci Listele\t(2)");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\tOgrenci Sil\t(3)");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\tÇıkış\t\t(0)");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("\tSeçiminiz=>\t");
        return Int32.Parse(Console.ReadLine());
    }
    private List<string> ogrenciler = [];//propertie (özellik)
    public void ogrenciEkle(string ogr) { 

        ogrenciler.Add(ogr.ToUpper()); 
    }//metot
    public void ogrenciSil(int ogrno)
    {

    }
    public void ogrenciListele(string baslik) {
        int say = 1;
        Console.WriteLine();
        Console.WriteLine(baslik.ToUpper());
        Console.WriteLine("\t--------------------");
        foreach (var ogr in ogrenciler)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(say);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" - {ogr}");
            say++;
        }
    }
}
