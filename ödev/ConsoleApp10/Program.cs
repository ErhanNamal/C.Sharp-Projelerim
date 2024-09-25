int sayi = 0;
int toplam = 0;
Console.WriteLine("Devam etmek için bir tuşa basınız (Çıkış için ESC ye basınız)");

while (true)
{
    Console.Write("Eklenecek sayıyı giriniz => ");
    string input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input))
    {
    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
    continue;
    }
    if (input.Equals("ESC", StringComparison.OrdinalIgnoreCase))
    {
        break;
        }

        try
    {
        sayi = Int32.Parse(input);
        toplam += sayi;
    }
    toplam += sayi;
    
}
Console.WriteLine("şimdiye kadar girdiğiniz sayıların toplamı => {0}",toplam);
