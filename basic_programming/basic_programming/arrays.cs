using System;
namespace basic_programming
{
	public class arrays
	{
        /*
		 
 //dizi tanımlama ve başlatma
int[] numaralar = new int[] {3,5,7,8,10};

//diziyi yazdırmak
foreach(var num in numaralar)
{
    Console.WriteLine(num);
}

Console.Write("Dizi boyutunu giriniz:");
int boyut = Convert.ToInt32(Console.ReadLine());

int[] sayilar = new int[boyut];

var r = new Random();

for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = r.Next(1, 10);//min = 1, max = 10
}

Console.Write("Sayilar dizisi içinde değerler:");

foreach(var num in sayilar)
{
    Console.Write(" "+num);
}


Console.WriteLine("******");

//matrix

double[,] matrix = new double[,] { { 1, 2, 3 }, { 2, 3, 4 },{3,4,5} };

for(int i = 0; i< matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        //diagonel eleman yakalama
        if(i == j)
        {
            matrix[i, j] = -1;
        }
        Console.Write(matrix[i, j]+" ");

    }
    Console.WriteLine();
}

//arraylist
ArrayList arrayList = new ArrayList();

//ekleme
arrayList.Add(10); //boxing
arrayList.Add("alper");
arrayList.Add(true);

//dolaşma
foreach(var num in arrayList)
{
    Console.WriteLine(num);
}

int[] sayilar1 = new int[] { 1, 2, 3, 4, 5, 6 };
arrayList.AddRange(sayilar1);
Console.WriteLine();

//eleman silme
arrayList.Remove(1);
arrayList.Remove("alper");
arrayList.Remove(true);

foreach (var num in arrayList)
{
    Console.WriteLine(num);
}
		 */
    }
}

