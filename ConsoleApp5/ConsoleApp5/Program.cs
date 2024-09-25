int sayi1;
int sayi2;
char islem;

Console.WriteLine("1. Sayıyı Giriniz:");
sayi1=Int32.Parse(Console.ReadLine());
Console.WriteLine("2. Sayıyı Giriniz");
sayi2=Int32.Parse(Console.ReadLine());
Console.WriteLine("Hangi işlem +,-,*,/:");
islem=Convert.ToChar(Console.ReadLine());

if (islem == '+')
{
    Console.WriteLine(sayi1 + sayi2);
}
else if (islem == '-')
{
    Console.WriteLine(sayi1 - sayi2);
}
else if (islem == '*')
{
    Console.WriteLine(sayi1 * sayi2);
}
else if (islem == ((sayi1 - sayi2) / sayi2))
{
    Console.WriteLine(sayi1 / sayi2);
}

