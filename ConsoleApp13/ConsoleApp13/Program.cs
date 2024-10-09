double s1 = 0;
double s2 = 0;
double sonuc = 0;
string islem = "";
bool kontrol = true;

ekranaBilgiYaz();

s1 = sGir();
s2 = sGir();
islemiAl();

ekranaYaz();

void ekranaBilgiYaz() { Console.WriteLine("Dört İşlem Uygulaması"); }

void mesaj(string mesaj,ConsoleColor onrek = ConsoleColor.Red)
{
    Console.ForegroundColor = onrek;
    Console.WriteLine(mesaj);
    Console.ForegroundColor = ConsoleColor.Gray;
}

double sGir()
{
	Console.Write("Sayıyı Gir => ");
	return Convert.ToDouble(Console.ReadLine());
}

void islemiAl()
{
	Console.Write("Lütfen İşlemi Girin: (+, -, *, /) => ");
	islem = Console.ReadLine();
    sonuc = dortIslemMetodu(islem);
}

double dortIslemMetodu(string islem)
{
	switch (islem)
	{
		case "+": return s1 + s2; break;
		case "-": return s1 - s2; break;
		case "*": return s1 * s2; break;
		case "/": return s1 / s2; break;
		default:
			mesaj("Lütfen geçerli bir işlem yapın (+, -, *, /)");
            kontrol = false;
            return 0;
		break;
	}
}

void ekranaYaz()
{
	if (kontrol)
	{
        mesaj($"Sonuç: {s1} {islem} {s2} = {sonuc}", ConsoleColor.Green);
    }
}
