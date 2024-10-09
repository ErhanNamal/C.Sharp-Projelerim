int sekil = 0;
double pi = 3.14;
int alan = 0;
int kisaYadaTaban = 0;
int uzunYadaYukseklik = 0;

pBilgi();
Sec();
hesapla();

void pBilgi()
{
    Console.WriteLine("Alan ve Çevre Hesaplama Programı");
}

void Sec()
{
    Console.Write("Lütfen İşlem için bir şekil seçin: (1-Dikdörtgen,2-Daire,3-Kare,4-Üçgen)=> ");
    sekil = Convert.ToInt32(Console.ReadLine());
}

void hesapla()
{
    ekranaYaz(alanH(sekil), cevreH(sekil));
}

int sGir(int sayi = 0, string metin = "")
{
    Console.Write((sayi == 0 ? "" : sayi + ". "));
    Console.Write((metin == string.Empty ? "Alanı Girin" : metin));
    Console.Write(" => ");

    return Convert.ToInt32(Console.ReadLine());
}
// alan hesaplama
double alanH(int sekil)
{
    switch (sekil)
    {
        case 1:
            kisaYadaTaban = sGir(1, "Kısa Kenar");
            uzunYadaYukseklik = sGir(2, "Uzun Kenar");
            return kisaYadaTaban * uzunYadaYukseklik;
            break;

        case 2: alan = sGir(); return pi * alan * alan; break;
        case 3: alan = sGir(); return alan * alan; break;

        case 4:
            kisaYadaTaban = sGir(); uzunYadaYukseklik = sGir();
            return kisaYadaTaban * uzunYadaYukseklik / 2; break;

        default: return 0; break;
    }
}
// başta girilen sayının çevre hesaplamak için
double cevreH(int sekil)
{
    switch (sekil)
    {
        case 1: return (kisaYadaTaban * uzunYadaYukseklik) * 2; break;
        case 2: return 2 * pi * alan; break;
        case 3: return pi * alan * 2; break;
        case 4: return kisaYadaTaban + uzunYadaYukseklik; break;
        default:
            Console.WriteLine("Hata Oluşmuştur.");
            return 0; break;
    }
}
// ekrana yazdırmak için
void ekranaYaz(double alan, double cevre)
{
    Console.Write($"Alan:  ");
    Console.WriteLine(Convert.ToString(alan));

    Console.Write($"Çevre: ");
    Console.WriteLine(Convert.ToString(cevre));
}
