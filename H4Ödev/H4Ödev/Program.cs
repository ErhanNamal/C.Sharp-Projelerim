bool kontrol = false;
int[] randomsayi = new int[10];
int[] tahmin = new int[10];


Randomsayıuret();
sayigiris(5,0);
Ekranayazdır();

void Ekranayazdır()
{
    if (kontrol)
    {
        Console.WriteLine("Kaybettiniz! Haklarınız bitti.");
    }
    else
    {
        Console.WriteLine("Kazandınız! Tebrikler!");
    }
}

void Hakkontrol(int kalanHak)
{
    if (kalanHak == 0)
    {
        Console.WriteLine("Haklarınız bitti!");
    }
    else
    {
        Console.WriteLine($"{kalanHak} kadar hakkınız kaldı.");
    }
}

void sayigiris(int hak,int i)
{
    for (i = 0; i < hak; i++)
    {
        Console.Write("Sayı Giriniz => ");
        int kulgiris = Convert.ToInt32(Console.ReadLine());

        foreach (int sayi2 in randomsayi)
        {
            if (sayi2 == kulgiris)
            {
                kontrol = true;
                break;
            }
            
        }
        if (kontrol) break;
    }
    Hakkontrol(hak - i);
}

void Randomsayıuret()
{
    Random random = new Random();
    int sayi = 0;
    while (sayi < 10)
    {
        int secsayi = random.Next(1, 21);
        bool ekleme = true;

        foreach (int psecsayi in randomsayi)
        {
            if (psecsayi == secsayi) { ekleme = false; break; }
        }

        if (ekleme)
        {
            randomsayi[sayi] = secsayi;
            sayi++;
        }
    }
}
