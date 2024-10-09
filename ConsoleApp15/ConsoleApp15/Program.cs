string ad; string soyad; string ders;
double not1= 0, not2= 0, not3= 0;
double ort;


isimsoyisim();
dersname();
notlar();
notsoru1();
notsoru2();
notsoru3();
ortalama();
ekranayazdır();

void isimsoyisim()
{
    Console.Write("Adınızı Giriniz=>");
    ad = Console.ReadLine();
    Console.Write("Soyadınızı Giriniz=>");
    soyad = Console.ReadLine();
}
void dersname()
{
    Console.Write("Ders adını Giriniz=>");
    ders = Console.ReadLine();
}
double notsoru1()
{
    Console.Write("1. Notu Giriniz =>");
    not1 = Convert.ToDouble(Console.ReadLine());
    return not1;  
}
double notsoru2()
{
    Console.Write("2. Notu Giriniz =>");
    not2 = Convert.ToDouble(Console.ReadLine());
    return not2;
}
double notsoru3()
{
    Console.Write("3. Notu Giriniz =>");
    not3 = Convert.ToDouble(Console.ReadLine());
    return not3;
}
void ortalama()
{
    ort=(not1 + not2 + not3) / 3;
    return;
}
void ekranayazdır() 
{
    Console.WriteLine();
    for (int i = 0; i < 40; i++)
    {
        Console.Write("_");
    }
    Console.WriteLine();
    Console.WriteLine($"Ad Soyad=>{ad} {soyad}");
    Console.WriteLine($"Ders=>{ders}");
    Console.WriteLine($"Notunuzun Ortalaması=>{ort}");
}

void notlar()
{
    for (int i = 1; i < 3; i++)
    {
        Console.Write($"{i}. Notu Giriniz =>");
        not1 = Convert.ToDouble(Console.ReadLine());
    }
}
