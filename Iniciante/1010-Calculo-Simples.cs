using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string[] peca1 = Console.ReadLine().Split(' ');
        string[] peca2 = Console.ReadLine().Split(' ');

        int quantidadePeca1 = int.Parse(peca1[1]);
        double precoPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

        int quantidadePeca2 = int.Parse(peca2[1]);
        double precoPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

        double valorPagar = ( (quantidadePeca1 * precoPeca1) + (quantidadePeca2 * precoPeca2) );

        Console.WriteLine($"VALOR A PAGAR: R$ {valorPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        
    }
}