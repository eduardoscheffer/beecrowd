using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        double totalSalary = salary + (vendas * 0.15);
        Console.WriteLine($"TOTAL = R$ {totalSalary.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}