int dogru = 0;
int yanlis = 0;
int bos = 0;
int net = 0;
string ders;
string[] cevaplar = new string[] { "a", "b", "c", "d" ,"a" ,"a","b","d","c","d"};
string[] kontrol = new string[cevaplar.Length];
Console.Write("Dersi giriniz=>");
ders=Console.ReadLine();

for (int i = 0; i < kontrol.Length; i++)
{
    Console.WriteLine($"{i + 1}. Sorunun cevabı nedir?");
    kontrol[i] = Console.ReadLine();

    if (string.IsNullOrEmpty(kontrol[i]))
    {
        bos++;
    }
    else if (kontrol[i] == cevaplar[i])
    {
        dogru++;
    }
    else
    {
        yanlis++;
    }
}

net = dogru - (yanlis % 3);
Console.WriteLine($"{ders} dersinin Sonuçları:");
Console.WriteLine($"Toplam Doğru=>{dogru}");
Console.WriteLine($"Toplam Yanlış=>{yanlis}");
Console.WriteLine($"Toplam Boş=>{bos}");
Console.WriteLine($"Toplam Net=>{net}");