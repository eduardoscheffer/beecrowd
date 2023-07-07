using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        
        int tempo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int velMedia = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double litrosGastos = (double) tempo * velMedia / 12;

        Console.WriteLine($"{litrosGastos.ToString("F3", CultureInfo.InvariantCulture)}");

    }
}