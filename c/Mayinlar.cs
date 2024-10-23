/*
 * int sinir = 20;
int seviye = 4;

Dictionary<int, bool> dizi = new Dictionary<int, bool>();

seviyeyiSec();

List<int> mayinlar = mayinlariYerlestir(seviye, sinir);

Ciz(sinir, seviye, dizi);

if (adimAt(sinir, seviye, mayinlar))
{
    MesajYaz("\t\t   oyun Bitti   ", ConsoleColor.Red);
}
else
{
    MesajYaz("\t\t   bravo   ", ConsoleColor.DarkGreen);
}

bool adimAt(int _sinir, int _seviye, List<int> _mayinlar)
{
    int sayi;
    int basamakSay = 0;
    bool mayin = false;
    for (int i = 1; i <= _sinir; i = i + _seviye)
    {
        sayi = sayiGir(i, i + _seviye - 1);
        if (sayi == _mayinlar[basamakSay])
        {
            dizi.Add(sayi, true);
            mayin = true;
        }
        else
        {
            dizi.Add(sayi, false);
        }
        basamakSay++;
        Ciz(_sinir, _seviye, dizi);
        if (mayin) { break; }
    }
    return mayin;
}

int sayiGir(int min, int max)
{
    int sayi = 0;
    while (true)
    {
        Console.Write($"Sıradaki Adımınızı Atınız({min} - {max}):=>");
        string girilen = Console.ReadLine();
        if (Int32.TryParse(girilen, out sayi))
        {
            if (sayi >= min && sayi <= max) { break; }
            else
            {
                MesajYaz("Hatalı Giriş-Aralık İhlali", ConsoleColor.Red);
            }
        }
        else
        {
            MesajYaz("Hatalı Giriş-Sayısal değerler gir", ConsoleColor.Red);
        }
    }
    return sayi;
}

void MesajYaz(string v, ConsoleColor renk)
{
    Console.BackgroundColor = renk;
    Console.WriteLine(v.ToUpper());
    Console.BackgroundColor = ConsoleColor.Black;
}

List<int> mayinlariYerlestir(int seviye, int sinir)
{
    List<int> mayinlar = new List<int>();
    Random r = new Random();
    for (int i = 1; i <= sinir; i = i + seviye)
    {
        mayinlar.Add(r.Next(i, i + seviye));
    }

    //mayinlar.ForEach(x =>Console.WriteLine(x));
    return mayinlar;
}

void Ciz(int _sinir, int _seviye, Dictionary<int, bool> _dizi)
{
    ConsoleColor a_renk = ConsoleColor.Black;
    ConsoleColor o_renk = ConsoleColor.White;
    Console.WriteLine("\t\t BAŞLANGIÇ");

    Console.Write("\t");
    for (var i = 0; i < sinir + 4; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();

    for (int i = 1; i <= _sinir; i++)
    {
        if (_dizi.Keys.ToList().IndexOf(i) == -1)
        {
            a_renk = ConsoleColor.Black;
            o_renk = ConsoleColor.White;
        }
        else
        {
            if (_dizi[i])
            {
                a_renk = ConsoleColor.Red;
            }
            else
            {
                a_renk = ConsoleColor.Green;
                o_renk = ConsoleColor.Black;
            }
        }
        Console.BackgroundColor = a_renk;
        Console.ForegroundColor = o_renk;

        Console.Write($"\t  {i}  ");
        if (i % _seviye == 0) Console.WriteLine();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }

    Console.WriteLine();
    Console.Write("\t");
    for (var i = 0; i < sinir + 4; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine();

    Console.WriteLine("\t\t BİTİS");
}

void seviyeyiSec()
{
    Console.Write("Lütfen Seviyeyi Seçin [kolay - 1,normal - 2, zor - 3]: ");
    int seviyeTuru = Convert.ToInt32(Console.ReadLine());

    switch (seviyeTuru)
    {
        case 1: seviye = 2; sinir = 10; break;
        case 3: seviye = 6; sinir = 42; break;
    }
}

*/