int okulno = 0;
string isim = "";
string ders = "";
double[] donem1 = new double[] { 0, 0, 0 };
double[] donem2 = new double[] { 0, 0, 0 };
double toplam1 = 0;
double toplam2 = 0;

Console.Write("İsim Soyisim Giriniz =>");
isim = Convert.ToString(Console.ReadLine());

Console.Write("Okul Numaranızı Giriniz =>");
okulno = Convert.ToInt32(Console.ReadLine());

Console.Write("Hangi Ders Olduğunu Giriniz=>");
ders = Convert.ToString(Console.ReadLine());

for (int i = 0; i < donem1.Length; i++)
{
    Console.Write($"1.dönem {i}.notunuzu giriniz=>");
    donem1[i] = double.Parse(Console.ReadLine());
    toplam1 += donem1[i];
}
for (int i = 0; i < donem2.Length; i++)
{
    Console.Write($"2.dönem {i}.notunuzu giriniz=>");
    donem2[i] = double.Parse(Console.ReadLine());
    toplam2 += donem2[i];
}

toplam1 = toplam1 / 3;
toplam2 = toplam2 / 3;
Console.WriteLine();
Console.WriteLine($"-{okulno}");
Console.WriteLine($"-{isim}");
Console.WriteLine($"-{ders}");
Console.WriteLine($"1.Dönem Ort={toplam1}");
Console.WriteLine($"2.Dönem Ort={toplam2}");