int sayi = 0;
int toplam = 0;
Console.WriteLine("Devam etmek için bir tuşa basınız (Çıkış için ESC ye basınız)");

while (true)
{
    Console.Write("Eklenecek sayıyı giriniz =>");
    if (Console.ReadKey().Key == ConsoleKey.Escape)
    sayi =Int32.Parse(Console.ReadLine());
    toplam += sayi;
    
}
Console.WriteLine("şimdiye kadar girdiğiniz sayıların toplamı => {0}",toplam);
