int sayi = 0;
int toplam = 0;
int sayac = 0;

Console.Write("Kaç tane Sayı Toplayacaksınız? =>");
sayac = Int32.Parse(Console.ReadLine()??"0");

    for (int i = 1; i <= sayac; i++)
{
        Console.Write("{0} Tane Sayı Giriniz =>",i);
        sayi=Int32.Parse(Console.ReadLine()??"0");
        toplam += sayi;
}
Console.Write("Girdiğiniz " + sayac + " adet sayının toplamı ");
    Console.ForegroundColor = ConsoleColor.Red;
Console.Write(toplam);
Console.ResetColor();
   Console.WriteLine(" olarak hesaplanmıştır");