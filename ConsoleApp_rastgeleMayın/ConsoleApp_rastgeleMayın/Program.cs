// See https://aka.ms/new-console-template for more information


Console.WriteLine("\tMAYINLARA DİKKAT---!");

List<int> mayinlar=rastgeleSayiUret(10,20);
giris_kontrol(5);

void giris_kontrol(int hak)
{
    List<int> girilenler = new List<int>();
    int girilen;
    int haksay = 0;
    while (haksay<hak) {
        girilen = sayiGir();
        if (benzersizlikKontrol(girilen, girilenler)) 
        { 
            girilenler.Add(girilen);
            if (kontrol_mayin(girilen, mayinlar))
            {
                haksay++;
                if (haksay == hak)
                {
                    MesajYaz("tebrikler Oyunu Kazandınız", ConsoleColor.Blue);
                }
                else {
                    MesajYaz(" Başarmanız için "+(hak-haksay) +" adımınız kaldı",ConsoleColor.Green);
                }
            }
            else 
            {
                MesajYaz("MAYINA BASTINIZ",ConsoleColor.Red); 
                MesajYaz("OYUN BİTTİ", ConsoleColor.Red);
                break; 
            }
        }
        else { MesajYaz("Daha Önce Bu Değeri Girdiniz",ConsoleColor.Red); }
    }
    
    
}

//List<int> dizi=new List<int>();
//bool kontrol = kontrol_mayin(sayi,dizi);
//bool oyunbitis = hakkontrol();
bool kontrol_mayin(int sayi, List<int> dizi)=>dizi.IndexOf(sayi) == -1;

int sayiGir()
{
    int sayi;
    while (true)
    {
        Console.Write("Deneme Sayınızı Giriniz");
        string girilenDeger = Console.ReadLine();        
        if (Int32.TryParse(girilenDeger, out sayi)) { break; }
        MesajYaz("Hatalı Giriş Tekrar Girin", ConsoleColor.Red);
    }
    return sayi;
}

void MesajYaz(string v,ConsoleColor renk)
{
    ConsoleColor _r = Console.BackgroundColor;
    Console.BackgroundColor = renk;
    Console.WriteLine($"{v.ToUpper()}");
    Console.BackgroundColor = _r;
}

List<int> rastgeleSayiUret(int v1, int v2)
{
    Random _random=new Random();
    List<int> mayinliste = new List<int>();
    int say = 0;
    int _mayin = 0;
    bool _kontrol = true;
    while (say < v1)
    { 
        _mayin=_random.Next(1,v2);
        _kontrol= benzersizlikKontrol(_mayin, mayinliste);
        if (_kontrol) 
        {
            mayinliste.Add(_mayin);
            say++; 
        }
    }
    return mayinliste;
}

bool benzersizlikKontrol(int _deger, List<int> _liste)
{
    return _liste.IndexOf(_deger)==-1?true:false;
}

Func<int,List<int>,bool> _b = (_deger, _liste) => _liste.IndexOf(_deger) == -1;
var _benzersizlikKontrol = (int _deger, List<int> _liste) => _liste.IndexOf(_deger) == -1;