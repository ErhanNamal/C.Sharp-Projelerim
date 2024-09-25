Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;

int a = 2;//başlangıç değeri vermek için olmasada olur
int b = 3;//başlangıç değeri vermek için olmasada olur
Console.Write("Kısa Kenarı Giriniz");
//tür dönüşümü(string=>int)
a=Int32.Parse(Console.ReadLine());
Console.Write("Uzun Kenarı Giriniz");
b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Alanı=" + (a * b) + " metrekare(m2)");
Console.WriteLine();

Console.WriteLine("Çevresi=" + (2 * (a + b)) + "metre(m)");
Console.WriteLine();