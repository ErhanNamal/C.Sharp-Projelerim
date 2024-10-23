string kadi = "";
string sifre = "";

const string baslik = "Kullanıcı Girişi ve Kayıt Sistemi";

Console.Title = baslik;
Console.WriteLine($"\t{baslik}");

ekran();

void ekran()
{
    _mesaj("Başlamadan önce sisteme kayıt olun", true, ConsoleColor.Cyan);

    kadi = kullaniciGirisi("Kullanıcı Adını girin");
    sifre = sifreGirisi("Şifrenizi girin");

    _mesaj("Şimdi sırada giriş yapma var lütfen az önce girdiğiniz bilgiler ile giriş yapım",true,ConsoleColor.Cyan);

    for (int i = 0; i < 20; i++)
    {
        Console.Write("-");
    }

    Console.WriteLine();

    kadiVeyaSifreKontrol(kadi,sifre);
}

void _mesaj(string? mesaj, bool line = true, ConsoleColor renk = ConsoleColor.Gray)
{
    ConsoleColor varsayilanRenk = Console.ForegroundColor;
    Console.ForegroundColor = renk;
    if(line) { Console.WriteLine($"{mesaj}"); }
    else { Console.Write($"{mesaj}"); }
    Console.ForegroundColor = varsayilanRenk;
}

string kullaniciGirisi(string mesaj)
{
   string girilen = "";

   while(true)
   {
        Console.Write($"{mesaj} => ");
        girilen = Console.ReadLine();

        if(string.IsNullOrEmpty(girilen))
        {
            _mesaj("Lütfen boş bırakmayınız.", true, ConsoleColor.Red);
        }
        else if (girilen.Length <= 8)
        {
            _mesaj("Karakter sayısı en az 8 olmalıdır.", true, ConsoleColor.Red);
        }
        else if (sayiKontrol(girilen))
        {
            _mesaj("Lütfen karakter girin.", true, ConsoleColor.Red);
        }
        else { break; }
   }

   return girilen;
}

string sifreGirisi(string mesaj)
{
   string girilen = "";

   while (true)
   {
        Console.Write($"{mesaj} => ");
        girilen = Console.ReadLine();
        
        if(string.IsNullOrEmpty(girilen))
        {
            _mesaj("Lütfen boş bırakmayınız.", true, ConsoleColor.Red);
        }
        else if (girilen.Length <= 8)
        {
            _mesaj("Karakter sayısı en az 8 olmalıdır.", true, ConsoleColor.Red);
        }
        else if (metinKontrol(girilen))
        {
            _mesaj("Lütfen sayı girin.", true, ConsoleColor.Red);
        }
        else { break; }
   }

   return girilen;
}

void kadiVeyaSifreKontrol(string kadi, string sifre,int hak = 5)
{
    int sayac = 0;
    string kadiKontrol  = "";
    string sifreKontrol = "";

    while (sayac < hak)
    {
        kadiKontrol = kullaniciGirisi("Kullanıcı Adını girin");
        sifreKontrol = sifreGirisi("Şifrenizi girin");

        _mesaj($"Kalan hakkınız: {hak}", true, ConsoleColor.Magenta);

        if (kadi != kadiKontrol)
        {
            hak--;
            _mesaj("Girdiğiniz kullanıcı adıyla az önce oluşturduğunuz kullanıcı adıyla eşleşmiyor", true, ConsoleColor.Red); 
        }else if(sifre != sifreKontrol)
        {
            hak--;
            _mesaj("Girdiğiniz şifreyle az önce oluşturduğunuz şifreyle eşleşmiyor", true, ConsoleColor.Red);
        }
        else if(hak == 0)
        {
            _mesaj($"{hak} hakkınız da tükendi", true, ConsoleColor.Red);
        }
        else
        {
            _mesaj("Giriş Başarılı", true, ConsoleColor.Green);
            break;
        }
    }
}

bool metinKontrol(string metin)
{
    bool _kontrol = true;

    foreach(char item in metin)
    {
        if(int.TryParse(item.ToString(), out int sayi)) 
        { _kontrol = false; }
    }

    return _kontrol;
}

bool sayiKontrol(string metin)
{
    bool _kontrol = false;

    foreach (char item in metin)
    {
        if(Char.IsDigit(item)) _kontrol = true;
    }

    return _kontrol;
}