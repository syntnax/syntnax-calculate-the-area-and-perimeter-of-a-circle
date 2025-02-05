using System;

class Program
{
    static void Main()
    {
        const double pi = Math.PI; // Sabit değer tanımı
        double alan, cevre, yaricap;

        Console.WriteLine("Dairenin yarıçapını giriniz:");

        string yaricapGirilen = Console.ReadLine();

        
        if (double.TryParse(yaricapGirilen, out yaricap))
        {
            cevre = 2 * pi * yaricap;
            alan = pi * Math.Pow(yaricap, 2);

            Console.WriteLine("Dairenin alanı: {0}", alan);
            Console.WriteLine("Dairenin çevresi: {0}", cevre);
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
        }
    }
}
