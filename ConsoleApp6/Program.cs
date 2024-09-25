int sayi1;
int sayi2;
int sayi3;

Console.WriteLine("1. Sayıyı Giriniz:");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyı Giriniz:");
sayi2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. Sayıyı Giriniz:");
sayi3 = Convert.ToInt32(Console.ReadLine());

if ((sayi1 > sayi2) & (sayi2 > sayi3))
{ Console.WriteLine(sayi1 + " > " + sayi2 + ">" + sayi3); }
else if  ((sayi1 > sayi2) & (sayi3 > sayi2)& (sayi1 > sayi3)) 
{ Console.WriteLine(sayi1 + " > " + sayi3 + ">" + sayi2); }
else if ((sayi2 > sayi1) & (sayi1 > sayi3))
{ Console.WriteLine(sayi2 + " > " + sayi1 + ">" + sayi3); }
else if ((sayi2 > sayi3) & (sayi3 > sayi2) & (sayi1 > sayi3))
{ Console.WriteLine(sayi2 + " > " + sayi3 + ">" + sayi1); }
else if ((sayi3 > sayi1) & (sayi1 > sayi2))
{ Console.WriteLine(sayi3 + " > " + sayi1 + ">" + sayi2); }
else if ((sayi3 > sayi2) & (sayi2 > sayi1) & (sayi3 > sayi1))
{ Console.WriteLine(sayi3 + " > " + sayi2 + ">" + sayi1); }