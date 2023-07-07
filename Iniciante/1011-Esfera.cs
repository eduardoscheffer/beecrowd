using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        
        double PI = 3.14159;
        double r = double.Parse(Console.ReadLine());

        double volume = ( (double) 4/3) * PI * Math.Pow(r, 3);

        Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
        
    }
}