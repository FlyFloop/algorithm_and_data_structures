// See https://aka.ms/new-console-template for more information



using basic_programming;

Console.WriteLine("Hello, World!");

double x = 2.5;
//int y = 2 * x;
var y = 2 * x; //var ile değişken tanımlanırken tipi atanır
Console.WriteLine(y);//ekrana çıktı verir
Console.WriteLine(y.GetType()); //y değişkeninin tipini verir


/*
aritmetik:
+, -, /, *, %
ilişkisel:
<, <=, >=, ==, !=
mantıksal:
&&
||
*/
int sayi1 = 20, sayi2 = 10;
Console.WriteLine(sayi1 + sayi2);
Console.WriteLine(sayi1 - sayi2);
Console.WriteLine(sayi1 * sayi2);
Console.WriteLine(sayi1 / sayi2);
Console.WriteLine(sayi1 % sayi2);

Console.WriteLine(sayi1 > sayi2);
Console.WriteLine(sayi1 < sayi2);
Console.WriteLine(sayi1 >= sayi2);
Console.WriteLine(sayi1 <= sayi2);
Console.WriteLine(sayi1 == sayi2);
Console.WriteLine(sayi1 != sayi2);
