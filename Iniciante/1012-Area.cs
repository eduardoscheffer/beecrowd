using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        
        string[] valores = Console.ReadLine().Split(' ');
        double A = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

        double areaTriangulo = (A * C / 2);
        Console.WriteLine($"TRIANGULO: {areaTriangulo:0.000}");

        double areaCirculo = 3.14159 * Math.Pow(C, 2);
        Console.WriteLine($"CIRCULO: {areaCirculo:0.000}");

        double trapezio = ((A + B) * C) / 2;
        Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");

        double areaQuadrado = Math.Pow(B, 2);
        Console.WriteLine($"QUADRADO: {areaQuadrado:0.000}");

        double areaRetangulo = A * B;
        Console.WriteLine($"RETANGULO: {areaRetangulo:0.000}");
        
    }
}