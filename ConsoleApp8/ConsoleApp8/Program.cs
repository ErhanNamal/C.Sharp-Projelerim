int bas =0;
int bit =0;
int toplam=0;

Console.Write("Başlangıç Sayısını Giriniz=");
bas =Convert.ToInt32(Console.ReadLine());
if (bas % 2 == 0)
{
    Console.Write("Bitiş Sayısını Giriniz=");
    bit = Convert.ToInt32(Console.ReadLine());

    for (int sayac = bas; sayac <= bit; sayac += 2)
    {
        toplam = sayac + toplam;
    }
    Console.WriteLine(toplam);
}
else
{
    Console.WriteLine("Başlangıcı çift giriniz");
}