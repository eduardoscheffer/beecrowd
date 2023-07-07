using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        
        string[] inputsP1 = Console.ReadLine().Split();
        double P1x = double.Parse(inputsP1[0], CultureInfo.InvariantCulture);
        double P1y = double.Parse(inputsP1[1], CultureInfo.InvariantCulture);

        string[] inputsP2 = Console.ReadLine().Split();
        double P2x = double.Parse(inputsP2[0], CultureInfo.InvariantCulture);
        double P2y = double.Parse(inputsP2[1], CultureInfo.InvariantCulture);
        
        double distancia = Math.Sqrt( Math.Pow((P2x - P1x), 2) + Math.Pow((P2y - P1y), 2) );

        Console.WriteLine($"{distancia.ToString("F4", CultureInfo.InvariantCulture)}");

    }
}