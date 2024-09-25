double sayi1 = 0;
double sayi2 = 0;
double sonuc = 0;
string islem = "";
bool hata = false;

Console.Write("1. Sayıyı Giriniz=");
sayi1 =Double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine();

Console.Write("2. Sayıyı Giriniz");
sayi2 =Double.Parse(Console.ReadLine() ?? "0");

Console.Write("işlem(+,-,*,/)=>");
islem = Console.ReadLine();
switch (islem)
{
	case "+": sonuc = sayi1 + sayi2;
		break;
	case "-": if (sayi1 > sayi2)
		{
			sonuc = sayi1 - sayi2;
		}
		else
		{
			sonuc = sayi2 - sayi1;
		}
		break;
	case "*": sonuc=sayi1 * sayi2;
		break;
	case "/": sonuc=sayi1 / sayi2;
		break;
	default:hata = true;break;
}
if (hata) { Console.WriteLine("Hatalı Giriş");}
else
{
Console.WriteLine("{0} {1} {2} = {3}",sayi1,islem,sayi2,sonuc);
}