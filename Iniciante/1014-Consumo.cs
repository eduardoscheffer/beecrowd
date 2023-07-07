using System;
using System.Globalization;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int km = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double litros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        double media = (double) km / litros;
        
        Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture) + " km/l" );
        
    }
}