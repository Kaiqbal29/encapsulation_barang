using encapsulation;
using System;

class Program
{
    static void Main(string[] args)
    {
        Barang brg1 = new Barang("Cocacola", 10000);
        Barang brg2 = new Barang("Chitato", 9000);
        Barang brg3 = new Barang("EsKrim", 19000);

        Console.WriteLine("Total Barang : " + Barang.TotalBarang);
        Console.WriteLine("===============================================");

        Console.WriteLine("Name  : " + brg1.Name);
        Console.WriteLine("Price : Rp." + brg1.Price);
        Console.WriteLine();
        Console.WriteLine("Name  : " + brg2.Name);
        Console.WriteLine("Price : Rp." + brg2.Price);
        Console.WriteLine();
        Console.WriteLine("Name  : " + brg3.Name);
        Console.WriteLine("Price : Rp." + brg3.Price);


        Console.ReadKey();
    }
}