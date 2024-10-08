Random random = new Random();
int sayi = 1;
bool tekrar = false;
int[] randomsayi = new int[10];
int[] tahmin = new int[10];
randomsayi[0] = random.Next(1, 21);
//int dtahmin = 0;
//int hak = 5;

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

for (int i = 0; i < 5; i++)
{
    Console.Write($"Girilen {i + 1}. Sayı => ");
    int kulgiris = Convert.ToInt32(Console.ReadLine());

    foreach (int sayi2 in randomsayi)
    {
        if (sayi2 == kulgiris)
        {
            tekrar = true;
            break;
        }
    }

    if (tekrar) break;
}

if (tekrar) { Console.Write("Kaybettiniz :d"); }
else { Console.Write("Kazandınız :D"); }
/*Console.WriteLine("1-20 arasında 10 adet sayı tahmin edin. ");
while (hak > 0)
{
    Console.WriteLine($"Kalan Hakkınız =>{hak}");
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"{i+1}. sayıyı tahmin edin =>");
        tahmin[i] = Convert.ToInt32(Console.ReadLine());
    }
    //kontrol tahmin
    for (int i = 0; i < 10; i++)
    {
        if (randomsayi[i] == tahmin[i])
        {
            dtahmin++;
        }
    }
    Console.WriteLine($"Doğru tahmin sayısı=>{dtahmin}");
    hak--;
    if (dtahmin == 10)
    {
        Console.WriteLine("Tebrikler Kazandınız :D");
        break;
    }
}
if (hak== 0)
{
    Console.WriteLine("Hakkınız Bitti, Kaybettiniz Cevap=>");
    foreach (var item in randomsayi)
    {
        Console.Write($"{sayi}");
    }
}
*/