int sayi = 0;
int toplam = 0;

while (true)
{
    
    Console.Write("Eklenecek sayıyı giriniz =>");
    sayi=Int32.Parse(Console.ReadLine() ?? "0");
    toplam += sayi;
    Console.Write("Devam etmek için bir tuşa basınız..");
    Console.WriteLine("(Çıkış için ESC ye basınız)");

    if (Console.ReadKey().Key==ConsoleKey.Escape) break;
}
Console.WriteLine("şimdiye kadar girdiğiniz sayıların toplamı => {0}",toplam);
