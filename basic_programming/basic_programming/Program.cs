using basic_programming;

Console.WriteLine("Hello, World!");

//while
int isa = 0;
int sayac = 0;
while (isa<10)
{
    sayac++;
    Console.WriteLine(sayac+" karesi ==> "+sayac*sayac);
    //0 bir değer geliceğini 5 ise 5 karakter boşluk bırakarak
    //devam etmesini söylüyor
    isa++;
}

//do while
int a = 10;
do
{
    Console.WriteLine("do çalıştı");
    a++;
} while (a < 10);

//for
int n = 5;
for(int i = 0; i < n; i++)
{
    for(int j = 0; j < i; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
}