double s1 = 0;double s2 = 0;double sonuc; string islem2;

ekranbilgi();
hangislem();
sGir();
s1 = sGir();
s2 = sGir();
dortislemmetodu($"{islem2}");
ekranaYaz();


void hangislem()
{
	Console.WriteLine("Lütfen bir islem seçiniz(+,-,/,*)=>");
	islem2 = Console.ReadLine();
}
void ekranbilgi()
{
    Console.WriteLine("4 işlem Uygulaması");
}
void dortislemmetodu(string islem)
{
	switch (islem)
	{
		case "+": sonuc = s1 + s2; break;
		case "-": sonuc = s1 - s2; break;
		case "*": sonuc = s1 * s2; break;
		case "/": sonuc = s1 / s2; break;

		default:Console.WriteLine("Hatalı Giriş Yaptınız");
			break;
	}
}
double sGir()
{
	Console.Write("Sayıyı Giriniz=>");
	return Convert.ToDouble(Console.ReadLine());
}
void ekranaYaz()
{
	Console.WriteLine();
}