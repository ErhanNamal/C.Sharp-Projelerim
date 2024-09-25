double a;
double b;

Console.Write("1. Sayıyı Giriniz");
a=Convert.ToDouble(Console.ReadLine());

Console.Write("2. Sayıyı Giriniz");
b=Convert.ToDouble(Console.ReadLine());



Console.WriteLine("Sayı1" + " Sayı2");
Console.WriteLine("-----" + " -----");
Console.WriteLine(a + "  +  " + b +"="+(a+b) );
Console.WriteLine(a + "  -  " + b + "=" + (a - b));
Console.WriteLine(a + "  *  " + b +"="+ (a*b));
Console.WriteLine(a + "  /  " + b +"="+ (a/b));