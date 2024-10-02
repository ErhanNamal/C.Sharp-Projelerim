int sayi = 0;
int toplam = 0;
bool devam = true;
string sayiMetin = null;
ConsoleKeyInfo tus;

while(devam)
{
    Console.Write("Sayı girin: (Çıkmak için  ESC ye basın)");
    while (true)
    {
        tus = Console.ReadKey(true);
        if (Char.IsDigit(tus.KeyChar))
        {
            Console.Write(tus.KeyChar);
            sayiMetin += tus.KeyChar;
        }
        else
        {
            if (tus.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                sayi = Int32.Parse(sayiMetin ?? "0");//sayimetin null geliyorsa null yerine 0 döndür
                sayiMetin = null;
                toplam += sayi;
                Console.WriteLine($"Girilen Sayıların Toplamı {toplam}");
                break;
            }
            if (tus.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("Teşekkür Ederiz...");
                devam = false;
                break;
            }
        }
    }
}
