Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;

int a;
int b;
int c;

Console.Write("1. Sayıyı Giriniz=");
//tür dönüşümü(string=>int)
a = Int32.Parse(Console.ReadLine());

Console.Write("2. Sayıyı Giriniz=");
b = Int32.Parse(Console.ReadLine());

Console.Write("3. Sayıyı Giriniz=");
c = Int32.Parse(Console.ReadLine());

Console.WriteLine(("Sayı1->")+a);
Console.WriteLine(("Sayı2->")+b);
Console.WriteLine(("Sayı3->")+c);
Console.WriteLine("+__________");
Console.WriteLine("Toplam=" + (a + b + c));